using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlobalImpact.Models
{
    [Table("Tbl_Endereco")]
    public class Endereco
    {
        [Column("Id"), HiddenInput]
        public int EnderecoId { get; set; }

        [Required, MaxLength(100)]
        public string Logradouro { get; set; }

        [Required, MaxLength(10)]
        public string Cep { get; set; }

        public string Cidade { get; set; }
    }
}