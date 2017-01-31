using System;
using System.Data.SqlClient;

namespace Arquitetura.CleanCode
{
    //===== Esse é um exemplo de código muito ruim ===== 

    public class REG01 //===== Nome de classe totalmente errado ===== 
    {
        //===== Exemplo de explicacao da classe QUE NÃO É NECESSARIO ===== 
        /// <summary>
        /// Faz a compra para o cliente
        /// </summary>
        /// <param name="Prod">Produto</param>
        /// <param name="Valor">Valor</param>
        /// <param name="Cat">Categoria</param>
        /// <param name="Desc">Desconto</param>
        /// <param name="ValorDesc">Valor desconto</param>
        /// <param name="Cli">Codigo cliente</param>
        /// <returns></returns>

        public bool Compra(string Prod, double Valor, int Cat, bool Desc, double ValorDesc, int Cli) // ===== Comprar oq? Parametro começam com letra minusculas ===== 
        {
            //calcula o desconto para o produto, caso haja desconto
            if (Desc)
            {
                Valor = Valor - ValorDesc;
            }

            //===== QUEBRANDO O SOLID ===== 

            //retorno do cliente
            SqlDataReader cliente;

            //encontrando o cliente
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT * FROM CLIENTES WHERE CODCLI = " + Cli;

                cn.Open();
                cliente = cmd.ExecuteReader();
            }

            //se o cliente for ativo realiza a compra
            if (Convert.ToBoolean(cliente["Ativo"]))
            {
                // realiza a compra

                // Não implementar o LOG
                // Log.GravaLog(Cli, Prod, Valor);
            }
            else
            {
                // Retorna falso, significa que o cliente nao conseguiu comprar
                return false;
            }

            return true; // ===== POR QUE NÃO RETORNA O OBJETO?
        }
    }
}



//ESTUDOS CLEANCODE:
//
//Principios de arquitetura - CleanCode
//  - 1 Nomes significativos                -> Escolha nomes que revelam intenção (Nomeiar classes e métodos)
//
//  - 2 Como você escreve o codigo          -> Use nomes fáceis de se encontrar
//                                          -> Use nomes proninciáveis
//                                          -> Evite palavras que não são palavras
//                                          -> não economize palavras
//                                          -> Revele a inteção do código
//                                          -> Evite palavras que podem servariáveis reservadas
//                                          -> Evite colocar o tipo no nome, ex: listaDeLancamento
//                                          -> Evite Trocadilhos
//                                          -> Não misture idiomas e mesclar nomes
//
//  - 3 Menos é mais, verificar os métodos  -> Método <= 20 linhas
//                                          -> Linha <= 100 caracteres
//                                          -> Classe <= 500 Linhas
//                                          -> Syntactic sugar c#  
//                                          -> Referente a Métodos
//                                              -> Extraia trechos em métodos privados.
//                                              -> Métodos devem fazer apenas uma coisa, faze-la certa e somente fazê-la.
//                                              -> Evite muitos parâmetros.
//                                              -> Não deixe o método mentir dizendo que faz uma coisa e faz outras escondidas.
//                                              -> Se um método tiver mais de uma responsabilidade extraia em dois ou mais.
//                                              -> Leia seu método de cima para baixo como uma narrativa, ele deve fazer sentido.
//                                              -> Aplique uma boa endentação
//
//  - 4 Não comente                         -> Comentário não vão ajudar um código ruim ser melhor interpretado
//                                          -> Um código que requercomentário, precisa ser reescrito
//                                          -> Não deixe techo de código comentado
//                                          -> MAS DEVO COMENTAR QUANDO:
//                                              -> Alerta consequencias que pode vir a causar 
//                                              -> Licença, direitos autorais e etc...
//                                              -> Necessidade de explicar uma regra de negócio interna.
//                                              -> Decisões de design de código
//
//  - 5 Tratamento de erros                 -> Tratar e prever possíveis exceções é de responsabilidade do desenvolvedor
//                                          -> Retorne exceptions e não códigos de erro.
//                                          -> Informe o maxímo que puder em sua exception 
//                                          -> Se necessario crie exceptions personalizadas para um problemaespecífico
//                                          -> Não retorne null
//                                          -> Não passe null
//                                          
//  - 6 Deixe o código mais limpo de como você a encontrou.