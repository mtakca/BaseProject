using System;
using BaseProject.Common.Models.CQRS.Queries.Reponse;

namespace BaseProjct.Api.Application.Interfaces.Helpers
{
    public interface IMathHelper 
    {
        CommonMathResponse Topla(int sayi1, int sayi2);
        CommonMathResponse Cikar(int sayi1, int sayi2);
        CommonMathResponse Carp(int sayi1, int sayi2);
        CommonMathResponse Bolme(int sayi1, int sayi2);

    }
}

