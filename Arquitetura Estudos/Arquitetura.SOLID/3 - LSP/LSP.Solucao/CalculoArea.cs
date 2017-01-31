using System;

namespace Arquitetura.SOLID.LSP.Solucao
{
    // A solução é a criação de uma classe base chamada paralelograma, qual representa o quadrado e o retangulo
    //onde podemos calcular a aréa. Assim na classe quadrado só validamos a se largura e altura são o mesmo.

    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo paralelogramo)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do paralelogramo");
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Altura + " * " + paralelogramo.Largura);
            Console.WriteLine();
            Console.WriteLine(paralelogramo.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            var quad = new Quadrado(5, 5);
            var rent = new Retangulo(10, 5);

            ObterAreaParalelogramo(quad);
            //Nesse calculo teremos o seguinte,  area = 5*5 = 25
            
            ObterAreaParalelogramo(rent);
            //Nesse calculo teremos o seguinte,  area = 10*5 = 50
        }

    }
}

//Ainda sim, há formas melhoras de fazer. Sem herança.
