# [Choice] .NET version: 7.0, 6.0, 5.0, 3.1, 6.0-bullseye, 5.0-bullseye, 3.1-bullseye, 6.0-focal, 5.0-focal, 3.1-focal
ARG VARIANT="7.0"
FROM mcr.microsoft.com/vscode/devcontainers/dotnet:0-${VARIANT}
# [Choice] Node.js version: none, lts/*, 16, 14, 12, 10
ARG NODE_VERSION="none"
RUN if [ "${NODE_VERSION}" != "none" ]; then su vscode -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi
# [Optional] Uncomment this section to install additional OS packages.
RUN apt-get update && \
    export DEBIAN_FRONTEND=noninteractive && \
    apt-get -qy full-upgrade && \
    apt-get install -qy curl && \
    apt-get -y install --no-install-recommends vim && \
    curl -sSL https://get.docker.com/ | sh

RUN dotnet tool install -g dotnet-ef
ENV PATH $PATH:/root/.dotnet/tools

                          
RUN wget -O dotnet.tar.gz https://download.visualstudio.microsoft.com/download/pr/764f2fec-710d-490d-a341-88636bce1a8d/35fc13fc20161a7d196200d9c2c6a8f0/dotnet-sdk-8.0.100-rc.1.23463.5-linux-x64.tar.gz \
    && dotnet_sha512='ac941fd16fd7c328f7cc44b132b4253ddb2b6a6c152af5f43c71c6cd0d468c89b7276ebf6c08895dcb6e5e25f7cae83b6fbacb91cfcc4a61d49b5657a834a901' \
    && echo "$dotnet_sha512 dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -zxf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz