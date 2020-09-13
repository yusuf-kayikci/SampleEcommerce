#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SampleEcommerce.BasketApi/SampleEcommerce.BasketApi.csproj", "SampleEcommerce.BasketApi/"]
COPY ["SampleEcommerce.Data/SampleEcommerce.Data.csproj", "SampleEcommerce.Data/"]
COPY ["SampleEcommerce.Core/SampleEcommerce.Core.csproj", "SampleEcommerce.Core/"]
COPY ["SampleEcommerce.Business/SampleEcommerce.Business.csproj", "SampleEcommerce.Business/"]
RUN dotnet restore "SampleEcommerce.BasketApi/SampleEcommerce.BasketApi.csproj"
COPY . .
WORKDIR "/src/SampleEcommerce.BasketApi"
RUN dotnet build "SampleEcommerce.BasketApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SampleEcommerce.BasketApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SampleEcommerce.BasketApi.dll"]
