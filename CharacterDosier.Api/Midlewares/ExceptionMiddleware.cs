using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CharacterDosier.API.Midlewares
{
	public class ExceptionMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogger<ExceptionMiddleware> _logger;

		public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
		{
			_logger = logger;
			_next = next;
		}
		public async Task InvokeAsync(HttpContext httpContext)
		{
			try
			{
				await _next(httpContext);
			}
			catch (ArgumentNullException ex)
			{
				_logger.LogError(ex, $"Http context was null!");
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, $"Something went wrong.");
				await HandleExceptionAsync(httpContext, ex);
			}
		}
		private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
		{
			context.Response.ContentType = "application/json";
			context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
			await context.Response.WriteAsync(
				new{
					StatusCode = context.Response.StatusCode,
					Message = $"Internal Server Error from the custom middleware. Exception message: {exception}"
				}.ToString()
			);
		}
	}
}

