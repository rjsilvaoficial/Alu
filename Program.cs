using System;

namespace Alu
{
    class Program
    {
        static SerieRepositorio Repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            // As 4 linhas abaixo alteram: nome na borda da janela, Cores do console e da fonte

            Console.Title = "Assiste logo uma!";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            //A linha abaixo altera o tamanho da janela da aplicação
            Console.WindowWidth = 50;



            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                try
                {
                    switch (opcaoUsuario)
                    {

                        case "1":
                            ListarSeries();
                            break;
                        case "2":
                            InserirSeries();
                            break;
                        case "3":
                            AtualizarSeries();
                            break;
                        case "4":
                            ExcluirSeries();
                            break;
                        case "5":
                            VisualizarSeries();
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();

                    }

                }
                catch
                {
                    Console.WriteLine("\tOi minha pessoa linda!\n" +
                        "\n   Você tem que selecionar uma opção da lista!\n");
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            
            Console.WriteLine("     Obrigado por utilizar nossos serviços!");
            Console.ReadLine();

        }


        private static void VisualizarSeries()
        {
            Console.WriteLine("\tDigite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = Repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }


        private static void ExcluirSeries()
        {
            Console.WriteLine("\tDigite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            Repositorio.Exclui(indiceSerie);

        }


        private static void AtualizarSeries()
        {
            Console.WriteLine("\tDigite o Id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("\t  {0} {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("\n  Digite o gênero conforme as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n     Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("\n    Digite o ano de ínicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("\n       Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie AtualizaSerie = new Serie(id: indiceSerie, genero: (Genero)entradaGenero, titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno);

            Repositorio.Atualiza(indiceSerie, AtualizaSerie);

        }


        private static void ListarSeries()
        {
            Console.WriteLine("\t    Listar séries\n");

            var lista = Repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("\tNenhuma série cadastrada");
                return;
            }

            foreach(var serie in lista)
            {
                Console.WriteLine($"#Id {serie.RetornoId()}: {serie.RetornoTitulo()}");
            }
        }


        private static void InserirSeries()
        {
            Console.WriteLine("\t Inserir nova série\n");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("\t    {0} {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("\n  Digite o gênero conforme as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n     Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("\n    Digite o ano de ínicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("\n       Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie NovaSerie = new Serie(id: Repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, descricao: entradaDescricao, ano: entradaAno);

            Repositorio.Insere(NovaSerie);

        }


        private static string ObterOpcaoUsuario()
        {

            Console.WriteLine("");
            Console.WriteLine("       Oi é muito bom te ver na ALU\n");
            Console.WriteLine("  Digite o número ou letra do que quer fazer:\n");

            Console.WriteLine("\t  1 - Listar séries");
            Console.WriteLine("\t  2 - Inserir nova série");
            Console.WriteLine("\t  3 - Atualizar série");
            Console.WriteLine("\t  4 - Excluir série");
            Console.WriteLine("\t  5 - Visualizar série");
            Console.WriteLine("\t  C - Limpar tela");
            Console.WriteLine("\t  X - Sair\n");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
