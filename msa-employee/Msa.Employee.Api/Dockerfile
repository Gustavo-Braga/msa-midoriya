#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Msa.Employee.Api/Msa.Employee.Api.csproj", "Msa.Employee.Api/"]
#COPY ["Msa.Employee.Api/Msa.Employee.CrossCutting.csproj", "Msa.Employee.CrossCutting/"]
#COPY ["Msa.Employee.Api/Msa.Employee.Domain.csproj", "Msa.Employee.Domain/"]
RUN dotnet restore "Msa.Employee.Api/Msa.Employee.Api.csproj"
COPY . .
WORKDIR "/src/Msa.Employee.Api"
RUN dotnet build "Msa.Employee.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Msa.Employee.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Msa.Employee.Api.dll"]