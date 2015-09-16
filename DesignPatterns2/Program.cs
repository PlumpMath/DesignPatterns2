using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;

namespace DesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            /***********CAP 2 - Flyweight***************/
        //    NotasMusicais notas = new NotasMusicais();

        //    IEnumerable<INota> doReMiFa = new List<INota>() {
        //    notas.Pega("do"),    
        //    notas.Pega("re"),    
        //    notas.Pega("mi"),    
        //    notas.Pega("fa"),    
        //    notas.Pega("fa"),    
        //    notas.Pega("fa"),    

        //    notas.Pega("do"),    
        //    notas.Pega("re"),    
        //    notas.Pega("do"),    
        //    notas.Pega("re"),    
        //    notas.Pega("re"),    
        //    notas.Pega("re"),

        //    notas.Pega("do"),    
        //    notas.Pega("sol"),    
        //    notas.Pega("fa"),    
        //    notas.Pega("mi"),    
        //    notas.Pega("mi"),    
        //    notas.Pega("mi"),

        //    notas.Pega("do"),    
        //    notas.Pega("re"),    
        //    notas.Pega("mi"),    
        //    notas.Pega("fa"),    
        //    notas.Pega("fa"),    
        //    notas.Pega("fa")
        //};
        //    Piano piano = new Piano();
        //    piano.Toca(doReMiFa);

        /****************CAP 3 - MEMENTO ***************/
            //Historico historico = new Historico();

            //Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());

            //contrato.Avanca();
            //historico.Adiciona(contrato.SalvaEstado());
            //Console.WriteLine(contrato.Tipo);
          
            //Console.ReadKey();

            /********************CAP 4 - DSLs e o Interpreter****************/

            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));

            IExpressao conta = new Soma(esquerda, direita);

            int resultado = conta.Avalia();
            Console.WriteLine(resultado);
        }
    }
}
