using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliosharp.Models;
using Microsoft.EntityFrameworkCore;


namespace Bibliosharp.Database;
    public class DbBibliosharp : DbContext
    {
        public DbSet<Author> entAuthors; 
        public DbSet<Book> entBooks; 
        public DbSet<BookHRecord> entBookHRecords; 
        public DbSet<Category> entCategory; 
        public DbSet<DocumentType> entDocumentTypes; 
        public DbSet<Rol> entRoles; 
        public DbSet<User> entUsers; 
        public DbBibliosharp(DbContextOptions options) : base(options)
        {
        }

    }
