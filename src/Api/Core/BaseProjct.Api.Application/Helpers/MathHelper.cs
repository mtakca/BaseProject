using System;
using BaseProjct.Api.Application.Interfaces.Helpers;
using BaseProject.Common.Models.CQRS.Queries.Reponse;

namespace BaseProjct.Api.Application.Helpers
{
    public class MathHelper : IMathHelper
    {
        public CommonMathResponse Bolme(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;

            return CreateResponse(sonuc, "carpma");
        }

        public CommonMathResponse Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;

            return CreateResponse(sonuc, "bolme");
        }

        public CommonMathResponse Cikar(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;

            return CreateResponse(sonuc, "toplama");
        }

        public CommonMathResponse Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;

            return CreateResponse(sonuc, "cikarma");
        }

        private CommonMathResponse CreateResponse(int sonuc, string zitDeger)
        {
            return new CommonMathResponse()
            {
                Sonuc = sonuc,
                Zitti = zitDeger
            };
        }
    }



}

