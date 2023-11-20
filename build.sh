#!/bin/bash

# Build with dotnet
dotnet publish -c Release -p:PublishSingleFile=true --self-contained true
#dotnet publish -c Release -r osx-arm64 -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true
#dotnet publish -c Release -r linux-x64 -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true

# Run help
bin/Release/net6.0/*/publish/lvfucs --help

# Run version
bin/Release/net6.0/*/publish/lvfucs --version

# Run quiet version
bin/Release/net6.0/*/publish/lvfucs -qv