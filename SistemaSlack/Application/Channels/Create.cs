using Domain;
using MediatR;
using Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Channels
{
    public class Create
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Descripcion { get; set; }

        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context ?? throw new ArgumentNullException(nameof(context));
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var channel = new Channel
                {
                    Id = request.Id,
                    Name = request.Name,
                    Description = request.Descripcion
                };

                _context.Channel.Add(channel);

                var success = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (success)
                    return Unit.Value;

                throw new Exception("Ocurrió un problema al guardar los datos");
            }
        }

    }
}

