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

Summary of the section
A modern framework
ASP.NET Core is a new framework created by Microsoft for building modern web applications and harnessing the full potential of the internet to offer our digital services and products.

The unique features of ASP.NET Core are:

• It is completely free and open-source;
• It is a new framework but built with Microsoft's twenty years of experience and enriched by feedback and contributions from the community;
• Easily enables writing applications compliant with European regulations, such as GDPR and cookie regulations;
• It is cloud-ready, designed to make it easy to transition from an on-premise server (located in the company) to a cloud service, which can provide better scalability and availability;
• Its modularity makes it an extremely lean and performant framework. We, as developers, decide precisely how to compose our application, to achieve a valid compromise between performance and functionality;
• It uses precautions that allow us to build secure applications by default;
• Being multi-platform, we can program an ASP.NET Core application from Linux, macOS, or Linux using an editor like Visual Studio Code.

What can we do with ASP.NET Core?
ASP.NET Core primarily allows building two types of web applications:

• Web UI: i.e. data management and/or consultation websites that will be accessible from a browser. These include highly interactive web applications built with javascript frameworks such as Angular and Vue.js. In this case, the users are PEOPLE;
• Web API: i.e. REST web services that facilitate integration with other external systems or that are accessed by mobile applications, developed by us or by third parties. In this case, the users are other APPLICATIONS.

Getting started
To start building a new application, we need to download .NET Core SDK which we get from the following address: https://www.microsoft.com/net/download

.NET Core SDK is available for all major platforms, for x86, x86-64, and ARM32 architectures. By writing an application only once, we can make it work without modifications on all supported platforms. We can use it to build console applications, IoT, and of course web applications with ASP.NET Core.

.NET Core SDK provides:

• The .NET Core Runtime that includes all components needed to run applications, basic objects and types, the garbage collector, the JIT compiler, and specific bindings that allow it to interact at a low level with the platform on which it is installed;
• The project creation and management tools, all accessible from a single dotnet command.

.NET Core is also available in the Runtime edition, which is devoid of creation and management tools and is designed to be installed on the server where the application will be made available to all our users.

Various versions of .NET Core SDK can be installed without any problem. The various versions will coexist within the system and at any time, we can choose to use any of the installed versions.

ASP.NET Core is programmed in C#, which is the language that enjoys full support. VB.NET and F# are also supported but quite limited.

Create and run the first application
The dotnet command is the entry point to all project management capabilities. To create a new application, we open the command prompt (also called 'terminal' on Linux and macOS), create an empty directory, go to it, and finally run:

dotnet new web

This will create a new application starting from a minimal template. To start the application, we run:

dotnet run

The application will start at two addresses:

http://localhost:5000

https://localhost:5001

We can copy one of the two and paste it into the address bar of our preferred browser to view the output produced by the application.
