using System.Collections.Generic;
using CadastroSeries.Interafaces;

namespace CadastroSeries.Models
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();

        public void Atualizar(int id, Serie entidade)
        {
            ListaSerie[id] = entidade;
        }

        public void Excluir(int id)
        {
           ListaSerie[id].Excluir();
        }

        public void Inserir(Serie entidade)
        {
            ListaSerie.Add(entidade);
        }

        public List<Serie> Listar()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornarPorId(int id)
        {
            return ListaSerie[id];
        }
    }
}