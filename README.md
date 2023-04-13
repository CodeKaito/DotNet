# Dotnet

### Index

1. [ Introduction. ](#introduction)
2. [ Change dotnet version](#version)

<a name="introduction"></a>
Introducing my latest repository dedicated to DotNet lovers, the DotNet Diary. This diary is designed for developers like me to keep a record of their coding activities, progress and milestones. It is a well-structured diary that captures every aspect of my coding life about dotnet.

<a name="version"></a>
## Change Dotnet version using the command line
To change the version of dotnet using the command line, follow these steps:

1. Open the command prompt or terminal.
2. Use the following commands to list the available dotnet versions:

   - Windows:

        ```
        dotnet --list-sdks
        ```

   - macOS and Linux:

        ```
        dotnet --list-sdks
        ```

3. Select the version of dotnet that you want to use.
4. Use the following command to set the dotnet version as the default:

   - Windows:

        ```
        dotnet new globaljson --sdk-version <version>
        ```

   - macOS and Linux:

        ```
        echo '{ "sdk": { "version": "<version>" } }' > global.json
        ```

5. Replace <version> with the selected dotnet version.
6. Verify that the dotnet version has been changed by running the following command:

   ```
   dotnet --version
   ```
