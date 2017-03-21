using System.Threading.Tasks;
using Sample.Core.Administraton.Data;
using MediatR;

namespace Sample.Core.Administraton.Application
{
    public class CreateHandler
    {
        public class Command : IRequest
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Description { get; set; }
        }

        public class Handler : IAsyncRequestHandler<Command>
        {
            public async Task Handle(Command message)
            {

                var customer = new Customer{Id = 1, Name = "MEMA", Description = "MEM from Administration"};
             
            }
        }
    }
}
