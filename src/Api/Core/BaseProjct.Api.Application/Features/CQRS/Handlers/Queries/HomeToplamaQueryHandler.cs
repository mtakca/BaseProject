using System;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using BaseProject.Common.Models.CQRS.Queries.Request;
using MediatR;

namespace BaseProjct.Api.Application.Features.CQRS.Handlers.Queries
{
    public class HomeToplamaQueryHandler : IRequestHandler<HomeToplamaQueryRequest, HomeToplamaQueryResponse>
    {
        public Task<HomeToplamaQueryResponse> Handle(HomeToplamaQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new HomeToplamaQueryResponse()
            {
                Sonuc = request.Sayi1 + request.Sayi2,
                Zitti = "Çıkarma"
            };

            return Task.FromResult(response);
        }

    }
}

