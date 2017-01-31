using System;

namespace Arquitetura.OOP
{
    public class Pessoa // Objeto Pessoa
    {
        //O objeto tem que ter estados e comportamentos.

        //Estados
        public int IdentificadorUnico;
        public string Nome { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }

        //Comportamentos, fazem sentidos ser dessa classe. 
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;
            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }


        //Construtor
        public Pessoa()
        {
            //O construtor se resume a dar possibilidades ou obrigar o usuário de uma classe a passar argumentos 
            //para o objeto durante o processo de criação do mesmo. Por exemplo, não podemos abrir um arquivo para 
            //leitura sem dizer qual é o nome do arquivo que desejamos ler! Portanto, nada mais natural que passar 
            //uma String representando o nome de um arquivo na hora de criar um objeto do tipo de leitura de arquivo, 
            //e que isso seja obrigatório.

            //Nesse caso de pessoa, como exemplo não vamos colocar nenhum parametro.
            //Mas seria correto dizer que para uma pessoa existir, seria de extrema necessidade passar por
            //parametro o nome da pessoa e a dataDeNascimento.
        }
    }
}
