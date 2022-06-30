using System;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using BaseProject.Common.Models.CQRS.Queries.Request;
using MediatR;

namespace BaseProjct.Api.Application.Features.CQRS.Handlers.Queries
{
    public class HomeCikarmaQueryHandler : IRequestHandler<HomeCikarmaQueryRequest, HomeCikarmaQueryResponse>
    {
        public Task<HomeCikarmaQueryResponse> Handle(HomeCikarmaQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new HomeCikarmaQueryResponse()
            {
                Sonuc = request.Sayi1 - request.Sayi2,
                Zitti = "Toplama"
            };

            return Task.FromResult(response);
        }

    }
}

