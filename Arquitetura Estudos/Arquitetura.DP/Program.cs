using System;
using Arquitetura.DP.Behavioral;
using Arquitetura.DP.Creational;
using Arquitetura.DP.Structual;

namespace Arquitetura.DP
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Escolha a operação");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Factory");
            Console.WriteLine("2 - Abstract Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("6 - Command");
            Console.WriteLine("7 - Observer");
            Console.WriteLine("8 - Strategy");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (opcao.KeyChar)
            {
                case '1':
                    FactoryMethod.Execucao();
                    break;
                case '2':
                    AbstractFactory.Execucao();
                    break;
                case '3':
                    Singleton.Execucao();
                    break;
                case '4':
                    Adapter.Execucao();
                    break;
                case '5':
                    Facade.Execucao();
                    break;
                case '6':
                    Command.Execucao();
                    break;
                case '7':
                    Observer.Execucao();
                    break;
                case '8':
                    Strategy.Execucao();
                    break;
            }

            Console.ReadKey();
        }
    }
}



//Prinípios de Arquitetura - Design Patterns
//
//  -> Design Pattern são padrões de código para soluções de problemas conhecidos. Geralmente para OOP.
//  -> O objetivo é não reinventar a roda, é aplicar uma solução com um bom design de código.
//  -> O conceito de padrões foi introduzido por 4 desenvolvedores intilulados GOF e hoje conta om 23 padrões fundamentais. Mas 
//    tambem existe mais de 80 padrões (que não são só do GOF) que em geral são variações dos 23 primeiros.

//  -> Os 23 padrões são divididos em: Creational Patterns => (Criacional) 
//                                                            Fornecem meios de criação de um objeto e de como ele será instanciado.
//                                                            - Abstract Factory (IMPORTANTE)
//                                                            - Builder
//                                                            - Factory Method (IMPORTANTE) => Que cria uma instancia de classes derivadas. 
//                                                            - Prototype
//                                                            - Singleton (IMPORTANTE) => é uma classe que trabalha com uma mesma instancia. 
//                                     Structural Patterns => (Estrutural) 
//                                                            Tratam da composição de objetos por heranças e interfaces para diferentes funcionalidades.
//                                                            - Adapter
//                                                            - Bridge
//                                                            - Composite
//                                                            - Decorator
//                                                            - Facede
//                                                            - Flyweight
//                                                            - Proxy
//                                     Behavioral Patterns => (Comportame) 
//                                                            Tratam das interações e comunicação entre os objetos além da divisão de responsabilidades.
//                                                            - Chain of Responsibility
//                                                            - Command
//                                                            - Interpreter
//                                                            - Iterator
//                                                            - Mediator
//                                                            - Memento
//                                                            - Observer
//                                                            - State
//                                                            - Strategy
//                                                            - Template Method
//                                                            - Visitor
//
//  -> PRINCIPAIS PADRÕES (FREQUENCIA DE USO DE 1 A 5)   
//      - Factory Method (5) => Define uma interface para criar um objeto, mas deixa que as subclasses decidam qual 
//                              classe deve ser instanciada. Factory Method permite que uma classe adie a instanciação 
//                              para uma subclasses.
//
//      - Abstract Factory (5) => Fornecer uma interface para criar famílias de objetos relacionados ou dependentes sem especificar 
//                                suas classes concretas.
//        
//      -
//      -
//      -
//      -
//      -
//      -
//
//
//
//
//
//
//
//
//
//
//




//  LEMBRETES MENTAIS
// -> Não viole o SOLID
// -> Utilize CleanCode
// -> Utilize o Design Patterns quando necessário.
// -> EVITE O PATTERNITE
//      - Patternite é o mal que o desenvolvedor sofre quando deseja aplicar todos os pattern conhecidos. 
//      - Não utiize sem conhecer.
//      - Apesar de conhecer só utilize os necessarios. 
// -> DRY (Don't repeat Yourself)
//      - Não se repetita, utilize VAR ao invés de int, string, decimal...
//      - O programador pradimático
// -> KISS (Keep It Simple, Stupid) 
//      - Mantenha as coisas simples, levando os mesmo conceitos que o PATTERNITE 
//      - Assim qualquer um com conhecimento basico de programação OO, principais Patterns e SOLID pode dar manuntenção. 
// -> YAGNI (You Ain't Gonna Need It)
//      - Uma orientação que sugere não adicionar funcionalidades ao código fonte de uma aplicação até que estas sejam 
//        realmente necessárias.
//      - Entregue, JUST IT!






