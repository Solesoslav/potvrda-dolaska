using System.ComponentModel.DataAnnotations;
namespace potvrda.Models
{
    public class OdgovoriRoditelja
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Molimo vas upišite vaše ime")]
        public string ImeDeteta { get; set; }
        [Required(ErrorMessage = "Molimo vas upišite ime deteta")]
        public string ImeRoditelja { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Telefon { get; set; }
        public bool? Viber { get; set; }
        public bool? PotvrdaDolaska { get; set; }
    }
}
