using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesCRUDRazor.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }

        [Display(Name = "Titulo")]
        [Required]
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyy}", ApplyFormatInEditMode = true)]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [Required]
        public string Genero { get; set; }

        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        // [Display(Name = "E-mail")]
        // [Required]
        // [RegularExpression("/^[a-z0-9.]+@[a-z0-9]+\\.[a-z]+\\.([a-z]+)?$/i")]
        // public string Email { get; set; }
    }
}