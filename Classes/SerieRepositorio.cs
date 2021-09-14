using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alu
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public void Insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public void Atualiza(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public Serie RetornaPorId(int id)
        {
            return ListaSerie[id];
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }


    }

}
