using MediatR;
using TraversalCoreProject.CQRS.Results.GuideResult;

namespace TraversalCoreProject.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDQueryResult>
    {
        public int Id { get; set; }

        public GetGuideByIDQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
