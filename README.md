_Built using .NET Core 7.0_

# Created solution using

```
dotnet new sln --name roman --output roman.cs
cd roman.cs
```

# Created csharp project

```
dotnet new classlib --name roman --output roman
dotnet sln add roman/roman.csproj
```

# Created test project

```
dotnet new nunit --name roman_tests --output roman_tests
dotnet sln add roman_tests/roman_tests.csproj
dotnet add roman_tests/roman_tests.csproj reference roman/roman.csproj
```

# Write Tests and Refactor code, etc.

If you clone the repo, you'll see this.

# Build and Test

```
dotnet build
dotnet test
```