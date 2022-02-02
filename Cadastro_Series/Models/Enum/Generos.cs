global using System.ComponentModel;

namespace Cadastro_Series.Models.Enum
{
    public enum Generos
    {
        [Description("Ação")]
        Acao = 1,
        [Description("Aventura")]
        Aventura = 2,
        [Description("Comédia")]
        Comedia = 3,
        [Description("Documentário")]
        Documentario = 4,
        [Description("Drama")]
        Drama = 5,
        [Description("Espionagem")]
        Espionagem = 6,
        [Description("Faroeste")]
        Faroeste = 7,
        [Description("Fantasia")]
        Fantasia = 8,
        [Description("Ficção Científica")]
        Ficcao_Cientifica = 9,
        [Description("Musical")]
        Musical = 10,
        [Description("Romance")]
        Romance = 11,
        [Description("Suspense")]
        Suspense = 12,
        [Description("Terror")]
        Terror = 13
    }
}
