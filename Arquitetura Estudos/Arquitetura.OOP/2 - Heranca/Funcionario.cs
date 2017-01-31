using System;

namespace Arquitetura.OOP
{
    public class Funcionario : Pessoa // Objeto Funcionario com herança de pessoa
    {
        //Estados
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
        
        //Comportamentos
        public int CalcularTempoContratado()
        {
            var dataAtual = DateTime.Now;
            var tempo = dataAtual.Year - DataAdmissao.Year;
            if (dataAtual < DataAdmissao.AddYears(tempo)) tempo--;

            return tempo;
        }
    }
}
