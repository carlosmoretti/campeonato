using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteMundivox.Data;
using TesteMundivox.Repositories;
using TesteMundivox.UnitOfWork.Interfaces;

namespace TesteMundivox.UnitOfWork
{
    public class UoW : IUnitOfWork
    {
        public DatabaseContext _db { get; set; }
        private JogoRepository _jogoRepository;
        private TimeRepository _timeRepository;

        public UoW(DatabaseContext db)
        {
            _db = db;
        }
        public JogoRepository JogoRepository
        {
            get
            {
                if (_jogoRepository == null)
                    _jogoRepository = new JogoRepository(_db);

                return _jogoRepository;
            }
        }
        public TimeRepository TimeRepository
        {
            get
            {
                if (_timeRepository == null)
                    _timeRepository = new TimeRepository(_db);

                return _timeRepository;
            }
        }

        public void Commit()
        {
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
