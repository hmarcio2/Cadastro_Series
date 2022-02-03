using Cadastro_Series.Models.Classes;
using Cadastro_Series.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace Cadastro_Series.Models
{
    public class Serie : EntidadeBase
    {
        //atributos
        [Range(1,13,ErrorMessage = "O Campo Gênero é obrigatório")]
        public Generos Genero { get; set; }        

        [Required(ErrorMessage = "O título é obrigatório!")] 
        [MinLength(1, ErrorMessage = "O nome da série deve ter no mínimo um caracter") ]
        public string? Titulo { get; set; } 
        public string Descricao { get; set; }
        
        [Range(1895, 2022, ErrorMessage = "O ano deve está entre 1895 e 2022")]
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
