using System;
using CadastroSeries.Models;
using CadastroSeries.Models.Enums;

namespace CadastroSeries
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();

        static void Main(string[] args)
        {

            string option = "";
            do{
                Console.Clear();
                option = ExibidorTelas.ExibirMenuPrincipal();
                ExecutarOpcao(option);
                Console.ReadKey();
            }while(option.ToLower().CompareTo("x") != 0);


        }

        static void ExecutarOpcao(string opcao)
        {
            Console.Clear();
            switch(opcao.ToLower())
            {
                case "1":
                    ListarSeriesSalvas();
                    break;
                case "2":
                    InserirNovaSerie();
                    break;
                case "3":
                    AtualizarSerie();
                    break;
                case "4":
                    RemoverSerie();
                    break;
                case "5":
                    VisualizarSerieEspecifica();
                    break;
                case "c":
                    Console.Clear();
                    break;
                case "x":
                    ExibidorTelas.ExibirMenuAgradecimento();
                    break;
                default:
                    Console.WriteLine("Selecione uma opção válida !");
                    break;
            }
        }

        static void ListarSeriesSalvas()
        {
            ExibidorTelas.ListarSeries(repositorioSerie.Listar());
        }

        static void InserirNovaSerie()
        {
            ExibidorTelas.ExibirMenuCadastroSerie();
            int generoNumero = ExibidorTelas.ExibirListaGenerosOpcoes();
            Console.WriteLine("| -> Informe um Título:                      |");
            string titulo = Console.ReadLine();
            Console.WriteLine("| -> Informe o Ano:                          |");
            int ano = Int32.Parse(Console.ReadLine());
            Console.WriteLine("| -> Informe uma Descrição:                  |");
            string descricao = Console.ReadLine();

            repositorioSerie.Inserir(new Serie(id: repositorioSerie.ProximoId(),
                                                genero: (Genero) generoNumero,
                                                titulo: titulo,
                                                descricao: descricao,
                                                ano: ano));
            
            Console.WriteLine("| -> Série Salva :)                  |");

        }

        static void AtualizarSerie()
        {
            ExibidorTelas.ExibirMenuAlterandoSerie();
            Console.WriteLine("| -> Informe o ID da Série:                  |");
            int idSerie = Int32.Parse(Console.ReadLine());
            try
            {
                repositorioSerie.RetornarPorId(idSerie);
            }catch(Exception e)
            {
                Console.WriteLine("| -> Série Não Atualizada: ID NÃO ENCONTRADO :(     |");
                return;
            }   
            int generoNumero = ExibidorTelas.ExibirListaGenerosOpcoes();
            Console.WriteLine("| -> Informe um Título:                      |");
            string titulo = Console.ReadLine();
            Console.WriteLine("| -> Informe o Ano:                          |");
            int ano = Int32.Parse(Console.ReadLine());
            Console.WriteLine("| -> Informe uma Descrição:                  |");
            string descricao = Console.ReadLine();

            repositorioSerie.Atualizar(idSerie, new Serie(id: idSerie,
                                                    genero: (Genero) generoNumero,
                                                    titulo: titulo,
                                                    descricao: descricao,
                                                    ano: ano));
            
            Console.WriteLine("| -> Série Atualizada :)                  |");
        }

        static void RemoverSerie()
        {
            ExibidorTelas.ExibirMenuRemovendoSerie();
            Console.WriteLine("| -> Informe o ID da Série:                  |");
            int idSerie = Int32.Parse(Console.ReadLine());
            try
            {
                repositorioSerie.RetornarPorId(idSerie);
            }catch(Exception e)
            {
                Console.WriteLine("| -> Série Não Removida: ID NÃO ENCONTRADO :(     |");
                return;
            }
            Console.WriteLine("| -> Deseja mesmo Remover a série?           |");
            Console.WriteLine($"|  {repositorioSerie.RetornarPorId(idSerie)}");
            Console.WriteLine("| 1 -> SIM                                   |");
            Console.WriteLine("| 2 -> NÃO                                   |");
            int confirmacao = Int32.Parse(Console.ReadLine());
            if(confirmacao == 1)
            {
                repositorioSerie.Excluir(idSerie);
                Console.WriteLine("| -> Série Removida :)                  |");
                return;
            } 
            Console.WriteLine("| -> Série Não Removida :(               |");

        }
        
        static void VisualizarSerieEspecifica()
        {
            ExibidorTelas.ExibirMenuSerieEspecifica();
            Console.WriteLine("| -> Informe o ID da Série:                  |");
            int idSerie = Int32.Parse(Console.ReadLine());
            try
            {
                repositorioSerie.RetornarPorId(idSerie);
            }catch(Exception e)
            {
                Console.WriteLine("| -> Série Não Exibida: ID NÃO ENCONTRADO :(      |");
                return;
            }
            ExibidorTelas.ExibirSerieEspecifica(repositorioSerie.RetornarPorId(idSerie));
        }
    }
}
