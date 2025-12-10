using System.ComponentModel;

using ModelContextProtocol.Server;

namespace SampleHttpMcpServer;


[McpServerToolType]
public static class MyTools
{
    [McpServerTool, Description("Adds two numbers.")]
    public static int Add(int a, int b) => a + b;

    [McpServerTool, Description("Gets the current time in a specified timezone.")]
    public static string GetCurrentTime(string timezone)
    {
        // Implement timezone logic here, e.g., using NodaTime
        return $"Current time in {timezone}: {DateTime.UtcNow}"; // Simplified for example
    }
}