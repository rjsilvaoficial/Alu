using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alu
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id,Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"Gênero: {Genero + Environment.NewLine}";
            retorno += $"Título: {Titulo + Environment.NewLine}";
            retorno += $"Descrição: {Descricao + Environment.NewLine}";
            retorno += $"Ano: {Ano + Environment.NewLine}";
            retorno += $"Excluído: {Excluido}";
            return retorno;
        }

        public string RetornoTitulo()
        {
            return Titulo;
        }

        public int RetornoId()
        {
            return Id;
        }

        public void Excluir()
        {
            Excluido = true;
        }



    }

}
