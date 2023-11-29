# 📃 Better Logging
Better Logging is a simple package that contains better methods for logging messages to the console.

<a href="https://www.nuget.org/packages/better-logging/">
    <img src="https://img.shields.io/nuget/vpre/better-logging.svg?maxAge=2592000?style=plastic" alt="NuGet">
</a>

## 📖 Documentation

### Log message
```c#
using Logging;

public class Program
{
    public static void Main(string[] args)
    {
        Logger.Log("Hello World!");
    }
}
```
---
### Log warning
```c#
using Logging;

public class Program
{
    public static void Main(string[] args)
    {
        Logger.LogWarning("Warning");
    }
}
```
---
### Log error
```c#
using Logging;

public class Program
{
    public static void Main(string[] args)
    {
        Logger.LogError("Error");
    }
}
```
---
### Log message with custom color
```c#
using Logging;

public class Program
{
    public static void Main(string[] args)
    {
        Logger.LogColor("Hello World!", ConsoleColor.Blue, ConsoleColor.Black);
    }
}
```
---
### Log message with format
```c#
using Logging;

public class Program
{
    public static void Main(string[] args)
    {
        Logger.Log("Hello World, I like {0} and {1}!", "C#", "JavaScript");
    }
}
```
---
### Log exception
```c#
using System;
using Logging;

public class Program
{
    public static void Main(string[] args)
    {
        Logger.LogException(new Exception("Error!"));
    }
}
```
