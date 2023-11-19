#!/bin/bash

# Build with dotnet
dotnet publish -c Release -p:PublishSingleFile=true --self-contained true
#dotnet publish -c Release -r osx-arm64 -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true
#dotnet publish -c Release -r linux-x64 -p:PublishReadyToRun=true -p:PublishSingleFile=true -p:PublishTrimmed=true --self-contained true
