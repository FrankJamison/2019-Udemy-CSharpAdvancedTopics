# C# Advanced Topics - Prepare for Technical Interviews Exercises

A collection of small console apps created while working through a C# advanced topics course (delegates, events, generics, LINQ, lambdas, dynamic binding, nullable types, and exception handling).

This repo contains a mix of:
- **.NET Framework 4.5 projects** (classic `.csproj`, built with Visual Studio/MSBuild)
- **SDK-style .NET Core project** (built/run with `dotnet`)

## Prerequisites (Windows)

### For .NET Framework 4.5 projects
You need **MSBuild** available.

Recommended options:
- **Visual Studio** (Community is fine), or
- **Build Tools for Visual Studio** (includes MSBuild)

Notes:
- If `msbuild` is not recognized, open **“Developer Command Prompt for VS”** (or **“Developer PowerShell for VS”**) and run the commands from there.
- Some machines may require the **.NET Framework 4.5 targeting pack** to build these projects.

### For the .NET Core project
Install an SDK that can build `netcoreapp2.1` (newer SDKs may still build it, but if you hit errors, install a compatible older SDK).

## Quick start

From the repo root, you can either:
- **Build/run a single project** (see each section below), or
- Open a `.sln` in Visual Studio and press **F5**.

---

## Delegates
**Folder:** `Delegates/`

Demonstrates delegates using an image processing pipeline. The app builds a multicast `Action<Photo>` and passes it into `PhotoProcessor.Process`, applying brightness/contrast and a custom “remove red eye” filter.

### Build + run (MSBuild)
From the repo root:

```bat
cd Delegates
msbuild Delegates.sln /p:Configuration=Debug
.\Delegates\bin\Debug\Delegates.exe
```

---

## DynamicBinding
**Folder:** `DynamicBinding/`

Demonstrates the `dynamic` keyword: assigning an `int` to a `dynamic` variable and then assigning it to a `long` without explicit casting.

### Build + run (MSBuild)

```bat
cd DynamicBinding
msbuild DynamicBinding.sln /p:Configuration=Debug
.\DynamicBinding\bin\Debug\DynamicBinding.exe
```

---

## EventsAndDelegates
**Folder:** `EventsAndDelegates/`

Demonstrates events with a publisher/subscriber pattern:
- `VideoEncoder` publishes `VideoEncoded`
- `MailService` and `MessageService` subscribe and react when encoding completes

### Run (`dotnet`)
From the repo root:

```bat
dotnet run --project .\EventsAndDelegates\EventsAndDelegates\EventsAndDelegates.csproj
```

Or from inside the project folder:

```bat
cd EventsAndDelegates\EventsAndDelegates
dotnet run
```

---

## ExceptionHandling
**Folder:** `ExceptionHandling/`

Demonstrates exception handling patterns:
- `try/catch` with specific vs generic exception types
- `using` to ensure `StreamReader` is disposed (finally-equivalent)
- calling a fake `YouTubeApi` that throws a custom exception

### Build + run (MSBuild)

```bat
cd ExceptionHandling
msbuild ExceptionHandling.sln /p:Configuration=Debug
.\ExceptionHandling\bin\Debug\ExceptionHandling.exe
```

---

## ExtensionMethods
**Folder:** `ExtensionMethods/`

Demonstrates extension methods:
- custom `StringExtensions.Shorten(...)`
- LINQ extension methods like `Max()` over an `IEnumerable<int>`

### Build + run (MSBuild)

```bat
cd ExtensionMethods
msbuild ExtensionMethods.sln /p:Configuration=Debug
.\ExtensionMethods\bin\Debug\ExtensionMethods.exe
```

---

## Generics
**Folder:** `Generics/`

Demonstrates generics by implementing/using:
- `GenericList<T>`
- `GenericDictionary<TKey, TValue>`
- a custom `Nullable<T>` wrapper with `HasValue` and `GetValueOrDefault()`

### Build + run (MSBuild)

```bat
cd Generics
msbuild Generics.sln /p:Configuration=Debug
.\Generics\bin\Debug\Generics.exe
```

---

## LambdaExpressions
**Folder:** `LambdaExpressions/`

Demonstrates lambda expressions with `List<T>.FindAll(...)` to find “cheap books” (price < 10) and print their titles.

### Build + run (MSBuild)

```bat
cd LambdaExpressions
msbuild LambdaExpressions.sln /p:Configuration=Debug
.\LambdaExpressions\bin\Debug\LambdaExpressions.exe
```

---

## Linq
**Folder:** `Linq/`

Demonstrates LINQ in both forms:
- Query syntax (`from/where/orderby/select`)
- Extension method syntax (`Where/OrderBy/Select`)

Also shows common operators: `Single`, `SingleOrDefault`, `FirstOrDefault`, `LastOrDefault`, paging with `Skip/Take`, and aggregation (`Count/Max/Min/Sum`).

### Build + run (MSBuild)

```bat
cd Linq
msbuild Linq.sln /p:Configuration=Debug
.\Linq\bin\Debug\Linq.exe
```

---

## NullableTypes
**Folder:** `NullableTypes/`

Demonstrates nullable value types (`DateTime?`) and patterns:
- `GetValueOrDefault()`
- `HasValue`
- null-coalescing operator `??` vs ternary operator

### Build + run (MSBuild)

```bat
cd NullableTypes
msbuild NullableTypes.sln /p:Configuration=Debug
.\NullableTypes\bin\Debug\NullableTypes.exe
```
