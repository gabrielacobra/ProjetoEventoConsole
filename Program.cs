using System;
using ProjetoEvento.ClassePai.ClassesFilhas;

namespace ProjetoEventoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";

            do
            {

                Console.WriteLine("==== Menu ====");
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Show");
                Console.WriteLine("2 - Teatro");
                Console.WriteLine("3 - Cinema");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        OpcaoShow(); //Método show criado para dizer o que vai ser feito caso o usuário digite 1, poderia ter escrito todas as ações aqui
                        break;
                    case "2":
                        break;
                    case "3":
                        break;

                    case "9":
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("");
                        break;
                }
            }
            while (opcao != "9");
        }
        static void OpcaoShow()
        {

            string opcao = "";

            do
            {
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Cadastrar novo show");
                Console.WriteLine("2 - Pesquisar show pelo título");
                Console.WriteLine("3 - Pesquisar show pela data");
                Console.WriteLine("4 - Voltar");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        {
                            Console.WriteLine("Digite o título do show:");
                            string titulo = Console.ReadLine();

                            Console.WriteLine("Digite o local:");
                            string local = Console.ReadLine();

                            Console.WriteLine("Digite a data:");
                            DateTime data = Convert.ToDateTime(Console.ReadLine());

                            Console.WriteLine("Digite a duração:");
                            string duracao = Console.ReadLine();

                            Console.WriteLine("Digite a classificação etária:");
                            int classificacao = Convert.ToInt16(Console.ReadLine()); //conversão de string para int

                            Console.WriteLine("Digite a lotação máxima:");
                            int lotacao = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o artista:");
                            string artista = Console.ReadLine();

                            Console.WriteLine("Digite o gênero musical:");
                            string genero = Console.ReadLine();

                            Show show = new Show(titulo, local, lotacao, duracao, classificacao, data, artista, genero);
                            if (show.Cadastrar() == true) //o == true é redundante, pois se está dentro do if é subentendido que é verdadeiro
                            {
                                Console.WriteLine("Cadastro realizado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Cadastro não realizado!");
                            }
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("Digite o título: ");
                            string titulo = Console.ReadLine();
                            Show show = new Show();
                            string resultado = show.Pesquisar(titulo);
                            Console.WriteLine(resultado);
                            
                            break;
                    }

                    case "3":
                    {
                        Console.WriteLine("Digite a data: ");
                        string data = Console.ReadLine(); //Datetime para data pois estamos pesquisando no arquivo em string
                        Show datashow = new Show();
                        string resultado = datashow.Pesquisar(Convert.ToDateTime(data));
                        Console.WriteLine(resultado);

                        break;
                    }                    
                }
            }
            while(opcao!="4");
        }
    }
}




