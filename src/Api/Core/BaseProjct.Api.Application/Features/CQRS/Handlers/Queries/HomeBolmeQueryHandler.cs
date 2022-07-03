using System;
using BaseProjct.Api.Application.Helpers;
using BaseProjct.Api.Application.Interfaces.Helpers;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using BaseProject.Common.Models.CQRS.Queries.Request;
using MediatR;

namespace BaseProjct.Api.Application.Features.CQRS.Handlers.Queries;

public class HomeBolmeQueryHandler : IRequestHandler<HomeBolmeQueryRequest, CommonMathResponse>
{
    private readonly IMathHelper _mathHelper;

    public HomeBolmeQueryHandler(IMathHelper mathHelper)
    {
        _mathHelper = mathHelper;
    }

    public Task<CommonMathResponse> Handle(HomeBolmeQueryRequest request, CancellationToken cancellationToken)
    {
        
        var response = _mathHelper.Bolme(request.Sayi1, request.Sayi2);

        return Task.FromResult(response);
    }
}

