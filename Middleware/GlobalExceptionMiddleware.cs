using LearningAssistant.Exceptions;

namespace LearningAssistant.Middleware;

public class GlobalExceptionMiddleware(
    RequestDelegate next,
    ILogger<GlobalExceptionMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (ValidationException exception)
        {
            await WriteErrorResponseAsync(
                context,
                StatusCodes.Status400BadRequest,
                exception.Message);
        }
        catch (ArgumentException exception)
        {
            await WriteErrorResponseAsync(
                context,
                StatusCodes.Status400BadRequest,
                exception.Message);
        }
        catch (KeyNotFoundException exception)
        {
            await WriteErrorResponseAsync(
                context,
                StatusCodes.Status404NotFound,
                exception.Message);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, "An unexpected server error occurred.");

            await WriteErrorResponseAsync(
                context,
                StatusCodes.Status500InternalServerError,
                "Unexpected server error.");
        }
    }

    private static Task WriteErrorResponseAsync(
        HttpContext context,
        int statusCode,
        string message)
    {
        context.Response.StatusCode = statusCode;

        return context.Response.WriteAsJsonAsync(
            new { error = message },
            context.RequestAborted);
    }
}
