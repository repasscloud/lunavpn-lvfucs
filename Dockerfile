# Use Alpine Linux as base image
FROM alpine:latest

WORKDIR /app

# Install necessary dependencies
RUN apk add --no-cache \
    bash \
    icu-libs \
    krb5-libs \
    libgcc \
    libintl \
    libssl1.1 \
    libstdc++ \
    zlib \
    libunwind

# Download and install dotnet
RUN wget https://dotnet.microsoft.com/download/dotnet/scripts/v1/dotnet-install.sh && \
    chmod +x ./dotnet-install.sh && \
    ./dotnet-install.sh -Channel 6.0.1xx

# Set environment variables
ENV DOTNET_ROOT=/root/.dotnet
ENV PATH=$PATH:$DOTNET_ROOT

# Run dotnet publish command as entrypoint
#ENTRYPOINT ["dotnet", "publish", "-c", "Release", "-r", "linux-musl-x64", "-p:PublishSingleFile=true", "--self-contained", "true"]
