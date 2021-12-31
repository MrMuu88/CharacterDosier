using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterDosier.API.Midlewares
{
	public class RequestLoggingMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILogger<RequestLoggingMiddleware> _logger;

		public RequestLoggingMiddleware(ILogger<RequestLoggingMiddleware> logger, RequestDelegate next)
		{
			_logger = logger;
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			var headers = context.Request.Headers.ToDictionary(h => h.Key, a => a.Value);

			var loggerState = new Dictionary<string, object>
			{
				["RequestId"] = "HTTP_" + Guid.NewGuid().ToString().Substring(30, 6)
			};

			using (_logger.BeginScope(loggerState))
			{
				_logger.LogInformation("Executing Api Reqest {@Method} {@Path}", context.Request.Method, context.Request.Path.Value);
				_logger.LogTrace("request Queries: {@Queries}", context.Request.Query.Select(q => string.Concat(q.Key, ":", q.Value)));
				_logger.LogTrace("request headers: {@Headers}", headers.Select(h => string.Concat(h.Key, " : ", h.Value)));

				await _next.Invoke(context);

				_logger.LogInformation($"Responded with {context.Response.StatusCode}");
			}
		}
	}
}
