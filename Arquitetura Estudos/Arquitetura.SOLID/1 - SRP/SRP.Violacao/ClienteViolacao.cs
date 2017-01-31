using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Arquitetura.SOLID.SRP.Violacao
{
    //Essa classe cliente tem os métodos de cliente, o que é bom. Porém realiza muitas tarefas. Como persistencia no banco 
    //e validações que não tem nada haver com cliente. (Tipo validar email e Cpf)
    
    //Há muita responsabilidade nessa classe, se houver algum erro, como saber se o email falhou ou a validação de CPF

    public class ClienteViolacao
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";

            if (CPF.Length != 11)
                return "Cliente com Cpf inválido";


            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL Cpf, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Email);
                cmd.Parameters.AddWithValue("cpf", CPF);
                cmd.Parameters.AddWithValue("dataCad", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem Vindo.";
            mail.Body = "Parabéns! Você está cadastrado.";
            client.Send(mail);

            return "Cliente cadastrado com sucesso!";
        }
    }
}
