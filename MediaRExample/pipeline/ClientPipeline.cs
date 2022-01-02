using MediaRExample.model;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace MediaRExample.pipeline
{
	public class ClientPipeline : IPipelineBehavior<Client, Unit>
	{
		private readonly ILogger<Client> _logger;

		public ClientPipeline(ILogger<Client> logger)
		{
			_logger = logger;
		}
		public async Task<Unit> Handle(Client request, CancellationToken cancellationToken, RequestHandlerDelegate<Unit> next)
		{
			_logger.LogInformation($"Handling {nameof(request)}");
			var response = await next();
			return response;
		}
	}
}
