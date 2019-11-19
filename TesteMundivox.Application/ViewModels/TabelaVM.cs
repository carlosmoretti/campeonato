using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteMundivox.Entities;

namespace TesteMundivox.Application.ViewModels
{
    public class TabelaVM
    {
        public List<Times> Times {get;set;}
        public List<Jogos> Jogos { get; set; }
    }
}
