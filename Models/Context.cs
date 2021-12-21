﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNovaViagens.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<CadastroPlanos> CadastroPlano { get; set; }


    }
}
