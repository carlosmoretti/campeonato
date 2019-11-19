using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteMundivox.Entities
{
    [Table("Times")]
    public class Times : EntityBase<int>
    {
        [Column("Nome")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Nome do time deve ter no mínimo 3 caracteres.")]
        [MaxLength(20, ErrorMessage = "Nome do time deve ter no máximo 20 caracteres.")]
        public string Nome { get; set; }
    }
}
