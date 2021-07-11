using AutoMapper;
using TeeBox.Infrastructure;

namespace TeeBox.Application.Handlers.Interfaces
{
    public abstract class GolfContextHandler
    {
        protected readonly GolfContext context;

        protected readonly IMapper mapper;

        public GolfContextHandler(GolfContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
    }
}
