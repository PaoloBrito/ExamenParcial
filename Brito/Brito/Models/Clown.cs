using System.ComponentModel.DataAnnotations;

namespace Brito.Models
{
    public enum TypeTricks
    {
        Palo,
        Pasta,
        Politico
    }


    public class Clown
    {
        [Key]
        public int ClownID { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2 )]
        public string NickName { get; set; }

        [Required]
        public TypeTricks Tricks { get; set; }


        [EmailAddress(ErrorMessage = "Le Estas pelando Fiera")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display (Name = "Cumpleaños")]
        public DataType Birthdate { get; set; }
    }
}