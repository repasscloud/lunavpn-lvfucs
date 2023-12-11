
# Change Log
All notable changes to this project will be documented in this file.
 
The format is based on [Keep a Changelog](http://keepachangelog.com/)
and this project adheres to [Semantic Versioning](http://semver.org/).

## [2.0.2] - 2023-12-11

### Fixed
- Removed all null values from `data.json` output [#13](https://github.com/repasscloud/lunavpn-lvfucs/issues/13)

### Changed
- Message when using `-h` or `--help` at call [#14](https://github.com/repasscloud/lunavpn-lvfucs/issues/14)

## [2.0.1] - 2023-12-10

### Fixed
- `libssl1.1` replaced by `libssl3` _(this is for the building environment, not part of the code)_

## [2.0.0] - 2023-12-10

### Changed
- Complete revision of code, now not compatible with any previous versions, used for development with ngrok [#11](https://github.com/repasscloud/lunavpn-lvfucs/issues/11)

## [1.2.3] - 2023-11-27

### Fixed
- Mapped peerX to peer3 for 1..3 in data.json [#9](https://github.com/repasscloud/lunavpn-lvfucs/issues/9)

## [1.1.2] - 2023-11-27

### Fixed
- Unable to generate data.json when the peerX values have not been created yet [#8](https://github.com/repasscloud/lunavpn-lvfucs/issues/8)

## [1.1.1]

### Fixed
- Bugs

## [1.1.0]

### Added
- Support to write server payload
- Logging support
- Native IP address detection
- Safety checking through application

### Fixed
- Replaced tabstops with 4 space characters

## [1.0.7] - 2023-11-20

### Fixed
- Output dir of `--generate-squid` for creds file

## [1.0.6] - 2023-11-20

### Fixed
- Output dir of `--generate-squid` for passwd file

## [1.0.4] - 2023-11-20

### Added
- Arg `-qv` prints version number only

### Changed

- Htpasswd generation
- Help and Version screens
 
## [1.0.3] - 2023-11-19
 
- Initial release, converted from C++ project