using MediatR;

namespace MediaRExample.model
{
	public class Client : IRequest
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
        
	}
}
