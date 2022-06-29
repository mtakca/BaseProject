using System;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using BaseProject.Common.Models.CQRS.Queries.Request;
using MediatR;

namespace BaseProjct.Api.Application.Features.CQRS.Handlers.Queries
{
    public class HomeCarpmaQueryHandler : IRequestHandler<HomeCarpmaQueryRequest, HomeCarpmaQueryResponse>
    {
        public Task<HomeCarpmaQueryResponse> Handle(HomeCarpmaQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new HomeCarpmaQueryResponse()
            {
                Sonuc = request.Sayi1 * request.Sayi2,
                Zitti = "Bölme"
            };

            return Task.FromResult(response);
        }
    }
}

