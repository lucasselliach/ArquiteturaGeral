using System;
using System.Linq;

namespace Arquitetura.SOLID.OCP.Solucao.ExtensionMethods
{
    //Nesse caso, essa classe está fechada para modificação e aberta para extensão.
    //Isso porque a utilização do ExtensionMethods permite expor os métodos que a debito em conta tem (métodos gerado
    //na hora da compilação, como pode ser visto na classe caixaeletronico) atravé da extensão dele nas classe DebitoContaCorrente
    //DebitoContaPoupança e DebitoContaInvestimento.

    //Há uma terceira forma mais correta de fazer isso que é com Injeção de dependencia, que será visto mais a frente. 
    
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public decimal Valor { get; set; }
        public string NumeroTransacao { get; set; }

        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15).Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero de transacao formatado
            return NumeroTransacao;
        }
    }
}
