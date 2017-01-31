using System;

namespace Arquitetura.OOP
{
    public class ExecucaoDeSistemaExemplo
    {
        //Digamos que essa classe é um processo de um sistema exemplo.
        //Então podemos utilizar da OOP para o desenvolvimento de uma aplicação.

        public ExecucaoDeSistemaExemplo()
        {
            //1-BASE -> Para criar um objeto do tipo Pessoa.
            var pessoa = new Pessoa(); // O new, depois de alocar a memória para esse objeto, devolve uma “ﬂecha”, isto é, um valor de referência. Quando você atribui isso a uma variável, essa variável passa a se referir para esse mesmo objeto.
            pessoa.IdentificadorUnico = 1;
            pessoa.Nome = "PessoaNome";
            pessoa.NomePai = "PessoaNomePai";
            pessoa.NomeMae = "PessoaNomeMae";
            pessoa.Celular = "999 9999-9999";
            pessoa.DataNascimento = Convert.ToDateTime("2000/01/01");
            var idade = pessoa.CalcularIdade();

            //2-HERANCA -> Para utlizar os conceitos de herança centre funcionario e pessoa.
            var funcionario = new Funcionario();
            funcionario.IdentificadorUnico = 1;
            funcionario.Nome = "PessoaNome";
            funcionario.NomePai = "PessoaNomePai";
            funcionario.NomeMae = "PessoaNomeMae";
            funcionario.Celular = "999 9999-9999";
            funcionario.DataNascimento = Convert.ToDateTime("2000/01/01");
            funcionario.Registro = "99999999999";
            funcionario.DataAdmissao = Convert.ToDateTime("2000/01/01");
            var idadeFuncionario = funcionario.CalcularIdade();
            var tempoFuncionario = funcionario.CalcularTempoContratado();
            
            //3-ABSTRACAO -> Uma forma de aplicar Abstração
            var cafeiteira = new Cafeteira("Eletrolux", 220);
            cafeiteira.Ligar();
            cafeiteira.Desligar();
            var retornaGastoCafeteira = cafeiteira.CalculoGastoTotal(2, 14.50);

            //4-POLIMORFISMO -> Uma forma de aplicar Polimorfismo
            var geladeira = new Geladeira();
            geladeira.Ligar();
            geladeira.CongelarFreezer();
            geladeira.DescongelarFreezer();
            geladeira.Desligar();
            var retornaGastoGeladeira = cafeiteira.CalculoGastoTotal(12, 14.50);

            var geladeiraConsul = new Geladeira("Consul", 110);
            geladeiraConsul.Ligar();
            geladeiraConsul.CongelarFreezer();
            geladeiraConsul.DescongelarFreezer();
            geladeiraConsul.Desligar();
            var retornaGastoGeladeiraConsul = cafeiteira.CalculoGastoTotal(10, 14.50);

            //5-ENCAPSULAMENTO -> Exemplo de encapsulamento, faço o mesmo que na abstração.
            var automacaoCafe = new AutomacaoCafe();
            automacaoCafe.ServirCafe();

            //6-HERANCA vs COMPOSICAO -> exemplo de composição
            //usando herança:

            var pessoaFisica = new PessoaFisica();
            pessoaFisica.IdentificadorUnico = 1;
            pessoaFisica.Nome = "PessoaNome";
            pessoaFisica.NomePai = "PessoaNomePai";
            pessoaFisica.NomeMae = "PessoaNomeMae";
            pessoaFisica.Celular = "999 9999-9999";
            pessoaFisica.DataNascimento = Convert.ToDateTime("2000/01/01");
            pessoaFisica.Cpf = "999.999.999-99";
            var idadePessoaFisica = pessoa.CalcularIdade();

            var pessoaJuridica = new PessoaJuridica();
            pessoaJuridica.IdentificadorUnico = 1;
            pessoaJuridica.Nome = "PessoaNome";
            pessoaJuridica.NomePai = "PessoaNomePai";
            pessoaJuridica.NomeMae = "PessoaNomeMae";
            pessoaJuridica.Celular = "999 9999-9999";
            pessoaJuridica.DataNascimento = Convert.ToDateTime("2000/01/01");
            pessoaJuridica.Cnpj = "99.999.999/9999-99";
            var idadePessoaJuridica = pessoa.CalcularIdade();
            //Utilizando a herança estamos expondado os atributos da pessoa, assim estamos quebrando um principio
            //da OOP que é o encapsulamento. E tambem tendo um alto acoplamento entre as classes. 

            //O uso da herança tem que ser muitoo bem justificado, devemos utilizar quando uma classe compartilha com outra classe 
            //filha as mesma responsabilidades. Isso será visto melhor em SOLID (OCP, LSP)

            // Com uso de composição (Baixo acoplamento)
            var pessoaComposicao = new Pessoa();
            pessoaComposicao.IdentificadorUnico = 1;
            pessoaComposicao.Nome = "PessoaNome";
            pessoaComposicao.NomePai = "PessoaNomePai";
            pessoaComposicao.NomeMae = "PessoaNomeMae";
            pessoaComposicao.Celular = "999 9999-9999";
            pessoaComposicao.DataNascimento = Convert.ToDateTime("2000/01/01");
            
            var cliente = new Cliente(1, pessoaComposicao);
            //Assim com composição, conseguimos manter o encapsulamento do cliente, não expondo a classe pessoa.
            //Prefira sempre utilizar composição. (A não ser que seja muito justificado utilizar herança, no caso quando uma classe é outra)
            

            //7-INTERFACE vs IMPLEMENTACAO -> Exemplo de interface VS Implementação

            //Segundo o principio do SOLID: "Programe para uma interface e não para uma implementação"
            //A Implementação gera acoplamento, o que dificulta a manutenção e a testabilidade do código.
            //Sendo assim, é errado fazer isso:

            var veiculo = new Veiculo();
            veiculo.Ligar();
            veiculo.Acelera();
            veiculo.Freia();
            veiculo.Desligar();
            
            //O certo seria utilizar a interface, para evitar o acoplamento.
            //Assim, primeiro vamos criar um objeto do tipo veiculo com injetor de dependencia (estudo em SOLID, no caso aqui será manual)
            var veiculoObjeto = new Veiculo();
            //E usaremos a abstração dele para realizar o processo
            var veiculoAbstracao = new VeiculoAbstracao(veiculoObjeto);
            veiculoAbstracao.VeiculoProcesso();
            //Sendo que assim evitamos o acomplamento já que se altera o métodos de ligar, acelerar, freiar e desligar não dará problema aqui
            //e sim na classe de abstração do veiculo que é a responsavel pelo processo.

            //Para finaliza, é de extrema importancia estudar SOLID
        }
    }
}
