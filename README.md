[![Build Status](https://dev.azure.com/thisissoftware/This%20is%20Squad%20Goals/_apis/build/status/this-is-squad-goals.api-user-service?branchName=master)](https://dev.azure.com/thisissoftware/This%20is%20Squad%20Goals/_build/latest?definitionId=2)

# UserAPI

Azure Functions App. Backend API and services for the user domain. Responsible for things like user signup, personal info, maybe app settings.

## Usage

REST API. Also publishes and subscribes to various topics (TBD).

## Topics

### Publish

* TBD

### Subscribe

* TBD

## Development

### Requirements

* C# .Net Core 2.0+ SDK
* C# .Net Core 2.0+ Runtime
* Azure Functions core tools

For VS Code, install the [Azure Functions](https://marketplace.visualstudio.com/items?itemName=ms-azuretools.vscode-azurefunctions) extension. This extension will enable local debugging and will manage the installation of the core tools and most other requirements.

If you need the .Net SDK and/or runtime, they can be downloaded from [Microsoft](https://dotnet.microsoft.com/download)

### Dependencies

* None (yet) 

### Test

From the CLI run `dotnet test`

The tests are written in XUnit and should be detected correctly by IDEs. For VS Code, use [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer) 

