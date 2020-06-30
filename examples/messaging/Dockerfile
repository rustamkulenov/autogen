FROM pinterb/jinja2 AS python-jinja2
WORKDIR /app
COPY . .
WORKDIR /app/
RUN rm Generated/*.cs
RUN python autogen.py messaging.j2
RUN rm messaging.j2
RUN rm messaging.j2.json

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
COPY --from=python-jinja2 /app .
RUN dotnet restore Messaging.csproj
RUN dotnet build Messaging.csproj -c Release
