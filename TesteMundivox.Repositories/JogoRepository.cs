using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteMundivox.Data;
using TesteMundivox.Entities;
using TesteMundivox.Repositories.Interface;

namespace TesteMundivox.Repositories
{
    public class JogoRepository : Repository<Jogos>, IJogoRepository
    {
        public JogoRepository(DatabaseContext db) : base(db)
        {
        }
    }
}
