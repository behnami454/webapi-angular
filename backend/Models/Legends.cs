using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace backend.Models
{
    public class Legends
    {
        [Key]
        public int LegendsId { get; set; }

        public string LegendsName { get; set; }

        public string LegendsApps { get; set; }

        public string LegendsPhotoFileName { get; set; }
    }
}
