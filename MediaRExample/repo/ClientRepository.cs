using DotNetCore.CAP;
using MediaRExample.model;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediaRExample.repo
{
	public class ClientRepository : IRequestHandler<Client>, ICapSubscribe
	{
		public Task<Unit> Handle(Client request, CancellationToken cancellationToken)
		{
			throw new System.NotImplementedException();
		}
	}
}
