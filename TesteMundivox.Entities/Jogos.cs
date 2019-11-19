using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesteMundivox.Entities
{
    [Table("Jogos")]
    public class Jogos : EntityBase<int>
    {
        [Column("TimeVencedor_Id")]
        public int TimeVencedor_Id { get; set; }
        [Column("Time2_Id")]
        public int Time2_Id { get; set; }
        [Column("Time1_Id")]
        public int Time1_Id { get; set; }
        [ForeignKey("Time1_Id")]
        public virtual Times Time1 { get; set; }
        [ForeignKey("Time2_Id")]
        public virtual Times Time2 { get; set; }
        [ForeignKey("TimeVencedor_Id")]
        public virtual Times Vencedor { get; set; }
        [Column("Round")]
        public int Round { get; set; }
    }
}
