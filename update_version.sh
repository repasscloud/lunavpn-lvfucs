#!/bin/sh

# Read the content of VERSION_INFO
version_info=$(cat VERSION_INFO)

# Escape special characters in the version_info
escaped_version_info=$(printf '%s\n' "$version_info" | sed -e 's/[]\/$*.^[]/\\&/g')

# Replace "vX.X.X" with the content of VERSION_INFO in all files
find . -type f -exec sed -i "s/vX\.X\.X/v${escaped_version_info}/g" {} +

