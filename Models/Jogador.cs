using System.ComponentModel.DataAnnotations;

namespace Inhouse.Models
{
    public class Jogador
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nick { get; set; }

        public string TagLine { get; set; }

        public string Puuid { get; set; }

        public int Wins { get; set; } = 0;

        public int Games { get; set; } = 0;

        public decimal Winrate { get; set; } = 0;
    }
}
