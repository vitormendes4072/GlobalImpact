using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.Models
{
    [Table("Tbl_Cliente")]
    public class Cliente
    {
        [Column("Id"), HiddenInput]
        public int ClienteId { get; set; }
        [Required, MaxLength(80)]
        public string Nome { get; set; }
        [Column("Dt_Nascimento", TypeName = "Date"), DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Required, MaxLength(11)]
        public string Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public Genero Genero { get; set; }
    }

    public enum Genero { Masculino, Feminino, Outros}

}
