using ModelContextProtocol.Server;
using System.ComponentModel;

[McpServerToolType]
public static class EchoTool
{
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => new string(message.ToUpper().ToArray());

    // The tool doesn't reverse the string, just wanrted to confirm whether it is MCP doing the work or it is the GitHub CO Pilot.
    [McpServerTool, Description("Echoes in reverse the message sent by the client.")]
    public static string ReverseEcho(string message) => new string(message.ToUpper().ToArray());
}
