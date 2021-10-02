namespace GameZone.API.Models
{
    public class Games
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Genero { get; set; }

        public string Plataforma { get; set; }

        public int Nota { get; set; }

        public string ImagemURL { get; set; }
    }
}