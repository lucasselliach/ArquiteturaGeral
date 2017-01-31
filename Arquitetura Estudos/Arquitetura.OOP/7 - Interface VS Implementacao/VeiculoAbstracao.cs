namespace Arquitetura.OOP
{
    public class VeiculoAbstracao
    {
        private readonly IVeiculo _veiculoAbstracao; //Estamos aqui programando para interface, considerando que receberemos o objeto criado.

        public VeiculoAbstracao(IVeiculo veiculoAbstracao)
        {
            _veiculoAbstracao = veiculoAbstracao;
        }

        public void VeiculoProcesso()
        {
            _veiculoAbstracao.Ligar();
            _veiculoAbstracao.Acelera();
            _veiculoAbstracao.Freia();
            _veiculoAbstracao.Desligar();
        }
    }
}

//OBS1:

//Quais são os principais motivos(na prática) que levam desenvolvedores a aplicar a prática de desenvolver 
//voltado para interface e não para implementação?

//Porque interfaces são apenas contratos do que o objeto tem ou é capaz de fazer.
//Então você pode usar qualquer objeto desde que o contrato esteja garantido.
//Tendo apenas o contrato você pode obter melhor:
//  Manutibilidade - alterações ficam mais isoladas, não precisa mudar tudo que aceitava uma classe concreta 
//  para aceitar outra necessária.Certos detalhes deixam de ser importantes e é possível mudar a implementação 
//  sem quebrar a aplicação.
//  Extensibilidade - Permite que novas implementações sejam feitas sem alterar tudo que esperava determinado 
//  objeto, então certos comportamentos se tornam mais genéricos podendo manipular objetos que ele desconhece 
//  desde que contenha o contrato esperado.
//  Testabilidade - é fácil substituir um objeto real de produção por um falso que facilite o teste.
//  Com a interface é possível reduzir o acoplamento.
//Ela ajuda no encapsulamento que é mais do que ter alguns membros privados.Priorizando o uso da interface o
//código diz claramente só o que ele precisa ali e as linguagens costumam impedir o acesso a outros membros não presentes na
//interface declarada mesmo que você saiba que estes membros existam no objeto.
//Em alguns casos usar interface é o mesmo que usar classes abstratas.
//Há uma resposta que mostra na prática como é importante ser o mais genérico possível no tipo de objeto que se 
//deseja e o mais específico possível no que se deseja fazer com este objeto.
//Isto facilita vários padrões de projeto, especialmente a injeção de dependência e inversão de controle.





//OBS2

//Qual a diferença entre ICollection, IList e List?
//Quando devo usar cada um especificamente?

//As duas primeiras são interfaces. A última é uma implementação concreta.Existe aí uma hierarquia. 
//O tipo List implementa uma IList que por sua vez implementa uma ICollection.É interessante citar ainda a 
//IEnumerable que é implementada pela ICollection.

//A IEnumerable permite enumerar itens.

//public interface IEnumerable<out T> : IEnumerable
//{
//    new IEnumerator<T> GetEnumerator();
//}

//A ICollection permite contar quantos itens existem na enumeração, adicionar, remover itens no fim da coleção,
//verificar a existência, entre outras operações.

//public interface ICollection<T> : IEnumerable<T>
//{
//    int Count { get; }
//    bool IsReadOnly { get; }
//    void Add(T item);
//    void Clear();
//    bool Contains(T item);
//    void CopyTo(T[] array, int arrayIndex);
//    bool Remove(T item);
//}

//A IList permite ainda inserir e remover itens em qualquer posição e buscar itens por índice.

//public interface IList<T> : ICollection<T>
//{
//    T this[int index] { get; set; }
//    int IndexOf(T item);
//    void Insert(int index, T item);
//    void RemoveAt(int index);
//}

//Pelo menos elas indicam que existem métodos que permitem fazer estas operações. Claro que a implementação correta destes
//métodos na classe concreta é que garantirá que tudo funcione como o esperado.

//Obviamente as interfaces não permitem realizar nenhuma operação com elas puramente, você precisa do tipo concreto 
//que no caso é o List.

//As interfaces são usadas para generalizar o tipo de uma variável, parâmetro ou retorna de um método. E isto é importante 
//para aproveitar código e facilitar a manutenção.Sempre que possível deve-se optar pelo tipo mais geral possível, pela interface.

//List<string> listaC = new List<string>();
//IList<string> lista = new List<string>();
//ICollection<string> colecao = new List<string>();
//IEnumerable<string> enumeracao = new List<string>();

//Note que todas variáveis implementam a classe List.Mas as variáveis que usam interface podem ter seu conteúdo substituído 
//por objetos de outros tipos concretos ou não sem problema algum, desde que estes tipos também implementem a interface que
//a variável foi declarada.Por exemplo, a variável colecao poderia trocar seu conteúdo por uma LinkedList que também implementa
//uma ICollection<T> sem problemas.Ambos os tipos possuem tudo o que o tipo da variável foi declarado.Exemplo:


//colecao = new LikedList();
//Uma coisa importante que além de generalizar o uso quando se usa a interface, é que ela também protege de uso indevido.
//No exemplo a variável enumeracao apesar de implementar uma lista e ter tudo o que uma lista permite, o compilador 
//impede o acesso aos membros que não fazem parte do tipo IEnumerable<T>. Ou seja, você não pode chamar o método Add(),
//ou o operador de índice[] ou ainda o Find(). Concretamente eles está lá mas como o código disse que a variável é de um 
//tipo superior, o compilador só deixa acessar o que está neste tipo, portanto só pode acessar o GetEnumerator().

//enumeracao.Reverse(); //gera erro de compilação
//colecao[0]; //erro também.
//lista.RemoveAt(0); //funciona
//listaC.Add("teste"); //funciona, o método está dentro da hierarquia
//Obviamente se você precisa acessar um Insert(), você não pode trabalhar só com um tipo IEnumerable ou mesmo ICollection.
//Mas pode usar um IList no lugar de usar a lista concreta mesmo. Já o uso do Sort() obrigaria ao uso do tipo concreto List.

//Note que esta generalização pela interface é mais vantajosa quando usada com parâmetros e retorno de métodos.

//O assunto é amplo mas a ideia fundamental é essa.

//Lembrando que os tipos genéricos são melhores que estes tipos simples que são considerados obsoletos, ou seja é melhor usar: 
//ICollection<Tipo>, IList<Tipo> e List<Tipo>.

//Lembrando que devemos programar para a interface e não para a implementação.


//REFERENCIAS:
//http://pt.stackoverflow.com/questions/86484/programar-voltado-para-interface-e-n%C3%A3o-para-a-implementa%C3%A7%C3%A3o-por-que
//http://pt.stackoverflow.com/questions/76316/diferen%C3%A7a-entre-icollection-ilist-e-list