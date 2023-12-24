using System.ComponentModel.DataAnnotations;

namespace DesafioRaizen.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Máximo de 50 caracteres")]
        public string Nome { get; set; }
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DataNascimento { get; set; }
        public int CEP { get; set; }

    }
}
