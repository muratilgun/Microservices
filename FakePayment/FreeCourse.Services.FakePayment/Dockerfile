FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim as build
WORKDIR /app
EXPOSE 80
COPY Shared/FreeCourse.Shared/*.csproj Shared/FreeCourse.Shared/
COPY FakePayment/FreeCourse.Services.FakePayment/*.csproj FakePayment/FreeCourse.Services.FakePayment/
RUN dotnet restore  FakePayment/FreeCourse.Services.FakePayment/*.csproj
COPY . .
RUN dotnet publish  FakePayment/FreeCourse.Services.FakePayment/*.csproj -c Release -o out
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim as runtime
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT [ "dotnet","FakePayment/FreeCourse.Services.FakePayment.dll" ]