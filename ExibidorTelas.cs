using System;
using System.Collections.Generic;
using CadastroSeries.Models;
using CadastroSeries.Models.Enums;

namespace CadastroSeries
{
    public static class ExibidorTelas
    {
        public static string ExibirMenuPrincipal()
        {
            Console.WriteLine("|            MENU -- CRUD Séries             |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("| 1 - (...) Listar Séries                    |");
            Console.WriteLine("| 2 - ( + ) Inserir Nova Série               |");
            Console.WriteLine("| 3 - ( UP ) Atualizar Série                 |");
            Console.WriteLine("| 4 - ( - ) Remover Série                    |");
            Console.WriteLine("| 5 - ( V ) Visualizar Série                 |");
            Console.WriteLine("| C - ( Clear ) Limpar Tela                  |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("| X - ( X ) SAIR                             |");

            string opcao = Console.ReadLine();
            return opcao;

        }

        public static void ExibirMenuCadastroSerie()
        {
            Console.WriteLine("|            MENU -- CRUD Séries             |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|          Cadastrando Nova Série            |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|--------------------------------------------|");
        }
        public static void ExibirMenuAlterandoSerie()
        {
            Console.WriteLine("|            MENU -- CRUD Séries             |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|            Alterando uma Série             |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|--------------------------------------------|");
        }

        public static void ExibirMenuRemovendoSerie()
        {
            Console.WriteLine("|            MENU -- CRUD Séries             |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|            Removendo uma Série             |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|--------------------------------------------|");
        }

        public static int ExibirListaGenerosOpcoes()
        {
            Console.WriteLine("|            GENERO - Opções                 |");
            Console.WriteLine("|--------------------------------------------|");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("|  {0} => {1}                            ", i, Enum.GetName(typeof(Genero), i));   
            }
            Console.WriteLine("|                                            |");
            Console.WriteLine("| -> Selecione um Genero:                    |");
            return Int32.Parse(Console.ReadLine());
        }

        public static void ListarSeries(List<Serie> lista)
        {
            Console.WriteLine("|            MENU -- CRUD Séries             |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|               Listando Séries              |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|--------------------------------------------|");

            foreach(Serie item in lista)
            {
                if(!item.IsExcluido())
                {    
                    Console.WriteLine($"| {item.RetornarId()} => {item.RetornarTitulo()}                    ");
                    Console.WriteLine("|-----------------------------------------");
                }
            }
        }

        public static void ExibirMenuSerieEspecifica()
        {
            Console.WriteLine("|            MENU -- CRUD Séries             |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|         Listando Série Específica          |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|--------------------------------------------|");
        }

        public static void ExibirSerieEspecifica(Serie objeto)
        {
            Console.WriteLine($"|  {objeto.ToString()}                       ");
            Console.WriteLine("|--------------------------------------------|");
        }

        public static void ExibirMenuAgradecimento()
        {
            Console.WriteLine("|            MENU -- CRUD Séries             |");
            Console.WriteLine("|--------------------------------------------|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|    Obrigado por utilizar o software :)     |");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|--------------------------------------------|");
        }
    }
}