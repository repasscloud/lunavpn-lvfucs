# LunaVPN-fu C# Edition

Welcome to LunaVPN-fu – where "fu" stands for "Functioning Unit"! Because in IT, we like things to function smoothly, just like a well-oiled code machine.

## Build Instructions

To build the application, run the following command in your terminal:

```bash
./build.sh
```

## Functionality

LunaVPN-fucs is your tool for creating a JSON file containing the server name and public IP address. It's designed to be a reliable "Functioning Unit" for your networking needs.

## Dependencies

The application relies on Microsoft's .NET Framework.

### Alpine Linux

If you are using Alpine Linux, make sure to have either `icu-dev` or both `icu-data-full` and `icu-libs` installed. These packages are necessary for proper functioning. You can install them using the package manager for Alpine, such as `apk`.

#### Install icu-dev

```bash
apk add --no-cache icu-dev
```

#### Install icu-data-full and icu-libs

```bash
apk add --no-cache icu-data-full icu-libs
```

These packages provide the necessary ICU (International Components for Unicode) libraries that the application requires.

## Usage

Discover LunaVPN fu's features:

- Use the `-v` flag to display version information.
- Provide an output path as the only argument to specify where to write the output JSON file. If no argument is provided, the file is written to `data.json` by default.

## License

LunaVPN-fu C# Edition is open-source and distributed under the [MIT License](LICENSE).

Explore, build, and enjoy the functionality of LunaVPN-fu C# Edition! 🚀
