using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteMundivox.Data;
using TesteMundivox.Repositories;

namespace TesteMundivox.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        DatabaseContext _db { get; set; }
        JogoRepository JogoRepository { get; }
        TimeRepository TimeRepository { get; }
        void Commit();
    }
}
