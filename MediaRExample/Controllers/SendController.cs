using MediaRExample.model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace MediaRExample.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SendController : ControllerBase
	{
		private readonly IMediator _mediator;

		public SendController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<Client> AddTaskAsync(Client client, CancellationToken cancellationToken)
		{
			await _mediator.Send(client, cancellationToken);
			return client;
		}

	}
}
