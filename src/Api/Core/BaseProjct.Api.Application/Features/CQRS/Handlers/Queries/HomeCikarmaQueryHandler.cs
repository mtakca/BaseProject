using System;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using BaseProject.Common.Models.CQRS.Queries.Request;
using MediatR;

namespace BaseProjct.Api.Application.Features.CQRS.Handlers.Queries
{
    public class HomeCikarmaQueryHandler : IRequestHandler<HomeCikarmaQueryRequest, CommonMathResponse>
    {
        public Task<CommonMathResponse> Handle(HomeCikarmaQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new CommonMathResponse()
            {
                Sonuc = request.Sayi1 - request.Sayi2,
                Zitti = "Toplama"
            };

            return Task.FromResult(response);
        }

    }
}

