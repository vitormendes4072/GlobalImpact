using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalImpact.Models
{
    [Table("Tbl_Alimento")]
    public class Alimento
    {
        [Column("Id"), HiddenInput]
        public int AlimentoId { get; set; }
        [Required, MaxLength(80)]
        public string Nome { get; set; }
        [Column("Dt_Validade", TypeName = "Date"), DataType(DataType.Date), Display(Name = "Data de Validade")]
        public DateTime DataValidade { get; set; }
        [Required, MaxLength(100), Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
        public Estado Estado { get; set; }
    }

    public enum Estado
    {
        Bom, Otimo, Ruim
    }
}
