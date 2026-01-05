# C# Advanced Topics - Prepare for Technical Interviews Exercises

A collection of small console apps created while working through a C# advanced topics course (delegates, events, generics, LINQ, lambdas, dynamic binding, nullable types, and exception handling).

This repo contains a mix of:
- **.NET Framework projects** (classic `.csproj`, built with Visual Studio/MSBuild)
- **SDK-style .NET project** (built/run with `dotnet`)

Current targets in this workspace:
- Most projects target **.NET Framework 4.8**
- `EventsAndDelegates` targets **.NET 8.0**

## Prerequisites (Windows)

### For .NET Framework projects
You need **MSBuild** available and the **.NET Framework 4.8 targeting pack/reference assemblies**.

Recommended options:
- **Visual Studio** (Community is fine), or
- **Build Tools for Visual Studio** (includes MSBuild)

Notes:
- If `msbuild` is not recognized, open **“Developer Command Prompt for VS”** (or **“Developer PowerShell for VS”**) and run the commands from there.
- If you see `MSB3644` about missing reference assemblies, install the appropriate .NET Framework targeting pack (this repo is configured for **4.8**).

### For the SDK-style .NET project
Install the **.NET 8 SDK**.

## Quick start

From the repo root, you can either:
- **Use VS Code Tasks/Debug** (recommended)
- **Build/run a single project manually** (see each section below)
- Open a `.sln` in Visual Studio and press **F5**

### VS Code workflow (recommended)

This workspace includes ready-made VS Code tasks and launch configurations:

- Build: `Terminal → Run Task… → Build: <ProjectName> ...`
- Run: `Terminal → Run Task… → Run: <ProjectName>`
- Debug: `Run and Debug` panel → `Debug: <ProjectName> ...` → `F5`

There is also a generic build task that builds the currently open solution file:

- `Build: Current .sln (MSBuild)`

---

## Delegates
**Folder:** `Delegates/`

Demonstrates delegates using an image processing pipeline. The app builds a multicast `Action<Photo>` and passes it into `PhotoProcessor.Process`, applying brightness/contrast and a custom “remove red eye” filter.

Expected output:
- `Apply brightness`
- `Apply contrast`
- `Apply RemoveRedEye`

Key files:
- `Delegates/Delegates/Program.cs` (wires up the delegate pipeline)
- `Delegates/Delegates/PhotoProcessor.cs` (runs filters via `Action<Photo>`)
- `Delegates/Delegates/PhotoFilters.cs` (filter methods)
- `Delegates/Delegates/Photo.cs` (photo “model” and loader)

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

Note: This project does not print output by default.

Key files:
- `DynamicBinding/DynamicBinding/Program.cs` (minimal `dynamic` example)

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

Key files:
- `EventsAndDelegates/EventsAndDelegates/Program.cs` (wires up subscriptions)
- `EventsAndDelegates/EventsAndDelegates/VideoEncoder.cs` (publisher + event)
- `EventsAndDelegates/EventsAndDelegates/VideoEventArgs.cs` (event payload)
- `EventsAndDelegates/EventsAndDelegates/MailService.cs` (subscriber)
- `EventsAndDelegates/EventsAndDelegates/MessageService.cs` (subscriber)
- `EventsAndDelegates/EventsAndDelegates/Video.cs` (model)

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

Notes:
- The `StreamReader` example intentionally points at `C:\file.zip` to trigger the error path.

Key files:
- `ExceptionHandling/ExceptionHandling/Program.cs` (examples)
- `ExceptionHandling/ExceptionHandling/Calculator.cs` (divide-by-zero demo)
- `ExceptionHandling/ExceptionHandling/YouTubeApi.cs` (throws custom exception)
- `ExceptionHandling/ExceptionHandling/YouTubeException.cs` (custom exception type)

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

Key files:
- `ExtensionMethods/ExtensionMethods/Program.cs` (calls the extensions)
- `ExtensionMethods/ExtensionMethods/StringExtensions.cs` (custom extension methods)

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

Key files:
- `Generics/Generics/Program.cs` (demo usage)
- `Generics/Generics/GenericList.cs` (generic list)
- `Generics/Generics/GenericDictionary.cs` (generic dictionary)
- `Generics/Generics/Nullable.cs` (custom `Nullable<T>` implementation)
- `Generics/Generics/DiscountCalculator.cs` (generic example)

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

Key files:
- `LambdaExpressions/LambdaExpressions/Program.cs` (lambda usage)
- `LambdaExpressions/LambdaExpressions/BookRepository.cs` (test data)
- `LambdaExpressions/LambdaExpressions/Book.cs` (model)

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

Key files:
- `Linq/Linq/Program.cs` (LINQ examples)
- `Linq/Linq/BookRepository.cs` (test data)
- `Linq/Linq/Book.cs` (model)
- `Linq/Linq/Nullable.cs` (custom `Nullable<T>` example)

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

Key files:
- `NullableTypes/NullableTypes/Program.cs` (nullable patterns demo)

### Build + run (MSBuild)

```bat
cd NullableTypes
msbuild NullableTypes.sln /p:Configuration=Debug
.\NullableTypes\bin\Debug\NullableTypes.exe
```
