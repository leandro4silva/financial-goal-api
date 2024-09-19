using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace FinTrack.Infraestructure.Commons.Extensions;

public static class LoggerExtensions
{
    private static void Log(ILogger logger, string type, string method, Object data, string filePath = "", int line = -1)
    {
        var fileName = Path.GetFileNameWithoutExtension(filePath);
        logger.LogInformation("{fileName} at line {line} - {methodName} - {type} - Trace - : {@data}",
            fileName, line, method, type, data);
    }

    private static void LogException(ILogger logger, string type, string method, Object exception, string filePath = "", int line = -1)
    {
        var fileName = Path.GetFileNameWithoutExtension(filePath);
        logger.LogError("{fileName} at line {line} - {methodName} - {type} - Exception - : {@exception}",
            fileName, line, method, type, exception);
    }

    public static void LogRequest(
        this ILogger logger,
        string method,
        Object request,
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int line = -1
    )
    {
        Log(logger, "Request", method, request, filePath, line);
    }

    public static void LogResponse(
        this ILogger logger,
        string method,
        Object response,
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int line = -1
    )
    {
        Log(logger, "Response", method, response, filePath, line);
    }

    public static void Loginfo(
        this ILogger logger,
        string method,
        Object info,
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int line = -1
    )
    {
        Log(logger, "Information", method, info, filePath, line);
    }

    public static void LogHandle(
        this ILogger logger,
        string method,
        Object info,
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int line = -1
    )
    {
        Log(logger, "Handler", method, info, filePath, line);
    }

    public static void LogResult(
        this ILogger logger,
        string method,
        Object response,
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int line = -1
    )
    {
        Log(logger, "Result", method, response, filePath, line);
    }

    public static void LogException(
        this ILogger logger,
        string method,
        Object response,
        [CallerFilePath] string filePath = "",
        [CallerLineNumber] int line = -1
    )
    {
        Log(logger, "Exception", method, response, filePath, line);
    }
}
