using System;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using MediatR;

namespace BaseProject.Common.Models.CQRS.Queries.Request
{
    public class HomeBolmeQueryRequest : IRequest<CommonMathResponse>
    {
    
            public int Sayi1 { get; set; }
            public int Sayi2 { get; set; }

    }
}

