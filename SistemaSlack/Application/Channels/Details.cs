using Application.Errors;
using Domain;
using MediatR;
using Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Channels
{
    public class Details
    {
        public class Query : IRequest<Channel>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Channel>
        {
            private DataContext _context;
            public Handler(DataContext context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
            }

            public async Task<Channel> Handle(Query request, CancellationToken cancellationToken)
            {

                var channel = await _context.Channel.FindAsync(request.Id);

                if(channel == null)
                
                    throw new RestException(System.Net.HttpStatusCode.NotFound, new {channel ="Not Found"});
                  
                
                return channel;
            }
        }
    }
}
