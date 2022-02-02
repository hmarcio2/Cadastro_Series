namespace Cadastro_Series.Models.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>
        {
            new Serie(0, Enum.Generos.Comedia, "The Office", "Esta adaptação americana se passa em uma empresa de papel em Scranton, Pensilvânia e tem um estilo de documentário semelhante ao original britânico estrelado por Ricky Gervais.", 2005),
            new Serie(1, Enum.Generos.Romance, "The Euphoria", "Um grupo de estudantes do ensino médio lida com diferentes situações típicas da idade como drogas, sexo, busca pela identidade, traumas, comportamento nas redes sociais e amizade.", 2019),
            new Serie(2, Enum.Generos.Fantasia, "The Wicther", "O mutante Geralt de Rívia é um caçador de monstros que luta para encontrar seu lugar em um mundo onde as pessoas, muitas vezes, são mais perversas do que as criaturas selvagens.", 2019),
            new Serie(3, Enum.Generos.Ficcao_Cientifica, "Foundation", "A Série da Fundação é uma obra de ficção científica escrita por Isaac Asimov que descreve em detalhes a história de um futuro distante e de como o destino de seus habitantes é influenciado por uma instituição chamada Fundação Enciclopédica", 1942)
        };
        
        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Listar()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
