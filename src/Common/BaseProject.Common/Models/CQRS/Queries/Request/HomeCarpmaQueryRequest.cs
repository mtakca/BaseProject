using System;
using BaseProject.Common.Models.CQRS.Queries.Reponse;
using MediatR;

namespace BaseProject.Common.Models.CQRS.Queries.Request
{
    public class HomeCarpmaQueryRequest : IRequest<HomeCarpmaQueryResponse>
    {
        public int Sayi1 { get; set; }
        public int Sayi2{ get; set; }

    }
}

