using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.Models
{
    [Table("Tbl_Empresa")]
    public class Empresa
    {
        [Column("Id"), HiddenInput]
        public int EmpresaId { get; set; }
        [Required, MaxLength(80)]
        public string Nome { get; set; }
        [Required, MaxLength(14)]
        public string Cnpj { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public IList<Alimento> Alimentos { get; set; }
    }
}
