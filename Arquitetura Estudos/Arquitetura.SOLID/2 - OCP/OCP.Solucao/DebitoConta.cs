using System;
using System.Linq;

namespace Arquitetura.SOLID.OCP.Solucao
{
    //USAR ABSTRAÇÃO é uma alternativa pois assim tornamos o DebitoConta o mais reutilizavel o possivel.
    //Assim está separado as classe filhos, como por exemplo a DebitoContaCorrente tem as resposabilidades separadas da 
    //debitoEmContaPoupança, e se uma não funcionar, não afetará a outra. 
    //Porém o problema de utilizar essa solução é a quebra o SRP, já que se essa classe mudar, vai mudar todas as classes filhas,
    //ou seja, estamos corropendo as classe filhas usando herança.

    //Então a solução correta seria utilizar a solução extensionMethods.
    
    public abstract class DebitoConta
    {
        //Como explicado em OOP, abstração, utilizamos o metodos abstrados para  que as classe filhas utilizem. 
        public string NumeroTransacao { get; set; }
        public abstract string Debitar(decimal valor, string conta);

        // A formatação da transação é algo genérico. Logo todas as classes filhas tem esse método em comum. 
        public string FormatarTransacao()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            // Numero de transacao formatado
            return NumeroTransacao;
        }
    }
}


