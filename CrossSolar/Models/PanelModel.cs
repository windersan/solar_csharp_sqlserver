using System.ComponentModel.DataAnnotations;

namespace CrossSolar.Models
{
    public class PanelModel
    {
        public int Id { get; set; }

        [Required]
        [Range(-90, 90)]
        [RegularExpression(@"^-*?\d+\.\d{6}$")]
        public double Latitude { get; set; }

        [RegularExpression(@"^-*?\d+\.\d{6}$")]
        [Range(-180, 180)] public double Longitude { get; set; }

        [RegularExpression(@"^\w{16}$")]
        [Required] public string Serial { get; set; }

        public string Brand { get; set; }
    }
}