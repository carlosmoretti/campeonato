using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesteMundivox.Entities
{
    public class EntityBase<T> where T : struct
    {
        [Column("Id")]
        [Key]
        public T Id { get; set; }
    }
}
