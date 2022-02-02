using Cadastro_Series.Models.Classes;
using Cadastro_Series.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace Cadastro_Series.Models
{
    public class Serie : EntidadeBase
    {       
        //atributos        
        public Generos Genero { get; set; }
        [Required]
        [MaxLength(30)]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [Required]
        
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        //metodos
        public Serie(int id, Generos genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public Serie() { }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;

            return retorno;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}
