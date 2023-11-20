#!/bin/sh

# Fetch the latest release URL of lvfucs from GitHub
lvfucs_url="https://github.com/repasscloud/lunavpn-lvfucs/releases/latest"

# Use curl to retrieve the HTML content, grep to find the latest tag, and cut to extract the tag version
lvfucs_latest_tag=$(curl -sSL "$lvfucs_url" | grep -o 'tag/v[0-9][^"]*' | cut -d'/' -f2 | head -n1)

# Download the lvfucs binary from the latest release and save it to /usr/local/bin
wget -O /usr/local/bin/lvfucs https://github.com/repasscloud/lunavpn-lvfucs/releases/download/$lvfucs_latest_tag/lvfucs

# Make the downloaded lvfucs binary executable
chmod +x /usr/local/bin/lvfucs
