﻿using System;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using BaseProject.Common.Models.CQRS.Queries.Request;
using MediatR;

namespace BaseProjct.Api.Application.Features.CQRS.Handlers.Queries
{
    public class HomeBolmeQueryHandler : IRequestHandler<HomeBolmeQueryRequest, HomeBolmeQueryResponse>
    {
        public Task<HomeBolmeQueryResponse> Handle(HomeBolmeQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new HomeBolmeQueryResponse()
            {
                Sonuc = request.Sayi1 / request.Sayi2,
                Zitti = "Çarpma"
            };

            return Task.FromResult(response);
        }
    }
}
