# dotnet-systemd-service
Create a .NET service that runs on linux and is controlled by systemd

## Notes
This service was created using the .NET 8 preview so steps were taken to create a dev container
with .NET 8 preview installed.  The initial dev container starts with a C# .NET 7 container
but the Dockerfile and docker-compose.yml setup downloads and installs the .NET 8 preview runtime.

When .NET 8 is release in November of this year at dotnet.conf, this sample will be updated to start
with a .NET 8 runtime instead.

The tutorial for installing .NET 8 preview runtime was taken from this blog post by Andy Watt called
[Getting Started with .NET 8: Seamless Setup with DevContainers](https://betterprogramming.pub/getting-started-with-net-8-seamless-setup-with-devcontainers-13851ee20f4e).  If you don't have an
account on Medium you are not able to see the entrire blog post but the code can be found on his
GitHub account at https://github.com/AndyWatt83/dotnet-8-workspace.

Adding a global.json file to the root folder will tell .NET to target the newly installed .NET 8
version instead of the .NET 7 version that is installed by default with the dev container.

global.json example file
```json
{
    "sdk": {
        "version": "8.0.100-preview.5.23303.2"
    }
}
```

### Requirements

- Since we are relying on dev containers, you will need Docker Desktop or equivalent installed