# SimpleLogging

Lightweight, single file logging library for C#.

## Features

- Lightweight and easy to integrate
- Minimal overhead
- Zero dependencies

## Installation

You can include SimpleLogging into your project in two ways:

1. **Add as a Project Reference:**
   - Download or clone the SimpleLogging repository.
   - Add a reference to `SimpleLogging/SimpleLogging.csproj` in your main project.

2. **Include the Source File:**
   - Copy the `SimpleLogging/SimpleLogging.cs` file into your project directory.

## Usage

```csharp
Action<Message>[] outputMethods = [(msg) => Console.WriteLine(msg)];
LogSettings logSettings = new() { AnsiColors = true, Debug = true };
Logger logger = new(outputMethods, logSettings);

logger.Log("Test info");
logger.LogWarning("Test warn");
logger.LogError("Test error");
logger.LogDebug("Test debug");
```

example output (colored in console):

```
15:43:59.769  INFO [         Program] : Test info
15:43:59.796  WARN [         Program] : Test warn
15:43:59.796 ERROR [         Program] : Test error
15:43:59.796 DEBUG [         Program] : Test debug
```
