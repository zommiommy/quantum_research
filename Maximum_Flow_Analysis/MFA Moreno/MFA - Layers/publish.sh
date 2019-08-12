#!/bin/sh
echo "Building linux release..."
dotnet publish -c release --self-contained -o ./RELEASE/linux64 -r linux-x64
echo "Done."
echo "Building win release..."
dotnet publish -c release --self-contained -o ./RELEASE/win64 -r win-x64
echo "Done."
echo "Building macOS release (>= macOS 10.12)..."
dotnet publish -c release --self-contained -o ./RELEASE/osx64 -r osx-x64
echo "Done."
