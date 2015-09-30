using System;
using DesignPatterns2.Cap4;

namespace DesignPatterns2.Cap5
{
    public class Impressora
    {

        public void ImprimeSome(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.AceitaUmaImpressoa(this);
            //esquerda
            Console.Write("+");
            soma.Direita.AceitaUmaImpressoa(this);
            //direita
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Esquerda.AceitaUmaImpressoa(this);
            //esquerda
            Console.Write("-");
            subtracao.Direita.AceitaUmaImpressoa(this);
            //direita
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        //public void ImprimeRaizquadrada(RaizQuadrada raizQuadrada)
        //{
        //    Console.WriteLine(raizQuadrada.Valor);
        //}
    }
}
