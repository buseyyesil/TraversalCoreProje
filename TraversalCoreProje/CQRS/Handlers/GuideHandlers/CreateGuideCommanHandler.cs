using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using TraversalCoreProje.CQRS.Commands.GuideCommands;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommanHandler
        : IRequestHandler<CreateGuideCommand, Unit>
    {
        private readonly Context _context;

        public CreateGuideCommanHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(
            CreateGuideCommand request,
            CancellationToken cancellationToken)
        {
         
            var guide = new Guide
            {
                Name = request.Name,
                Description = request.Description,

                Image = "/images/default-guide.jpg", 
                XUrl = "#",
                InstagramUrl = "#",

                Status = true
            };

            _context.Guides.Add(guide);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
