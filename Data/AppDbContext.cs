﻿using Microsoft.EntityFrameworkCore;
using CadastroDeProdutos.Models;

namespace CadastroDeProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}