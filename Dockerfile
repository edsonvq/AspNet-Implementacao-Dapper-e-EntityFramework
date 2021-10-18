FROM mcr.microsoft.com/dotnet/sdk:2.2 AS dotnet-build
LABEL maintainer "Edson V. Queiroz <edsonvq@outlook.com>"

WORKDIR /src
COPY . /src
RUN dotnet restore "/Mvc.Dapper.Entity.MVC/Mvc.Dapper.Entity.MVC.csproj"
RUN dotnet build "/Mvc.Dapper.Entity.MVC/Mvc.Dapper.Entity.MVC.csproj" -c Release -o /app/build

FROM dotnet-build AS dotnet-publish
RUN dotnet publish "/Mvc.Dapper.Entity.MVC/Mvc.Dapper.Entity.MVC.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:2.2 AS final
WORKDIR /app
EXPOSE 5050
RUN mkdir /app/wwwroot
COPY --from=dotnet-publish /app/publish .
ENTRYPOINT ["dotnet", "Mvc.Dapper.Entity.MVC.dll"]
