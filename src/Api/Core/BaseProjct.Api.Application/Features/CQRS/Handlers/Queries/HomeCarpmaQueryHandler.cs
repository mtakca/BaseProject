using System;
using BaseProjct.Api.Application.Interfaces.Helpers;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using BaseProject.Common.Models.CQRS.Queries.Request;
using MediatR;

namespace BaseProjct.Api.Application.Features.CQRS.Handlers.Queries;

public class HomeCarpmaQueryHandler : IRequestHandler<HomeCarpmaQueryRequest, CommonMathResponse>
{
    private readonly IMathHelper _mathHelper;

    public HomeCarpmaQueryHandler(IMathHelper mathHelper)
    {
        _mathHelper = mathHelper;
    }

    public Task<CommonMathResponse> Handle(HomeCarpmaQueryRequest request, CancellationToken cancellationToken)
    {
        var response = _mathHelper.Carp(request.Sayi1, request.Sayi2);

        return Task.FromResult(response);
    }
}

