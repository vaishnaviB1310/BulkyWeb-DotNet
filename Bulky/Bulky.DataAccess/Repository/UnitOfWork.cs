﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICategoryRepository Category {get;private set;}

    public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
        Category = new CategoryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
