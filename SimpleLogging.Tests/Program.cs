namespace SimpleLogging.Tests;

public static class Program
{
  static void Main()
  {
    Action<Message>[] outputMethods = [(msg) => Console.WriteLine(msg)];
    LogSettings logSettings = new() { ColorType = ColorType.ANSI, Debug = true };
    Logger logger = new(outputMethods, logSettings);

    logger.Log("Test info");
    logger.LogWarning("Test warn");
    logger.LogError("Test error");
    logger.LogDebug("Test debug");
  }
}