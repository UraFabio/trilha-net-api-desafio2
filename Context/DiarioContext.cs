using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trilha_net_api_desafio.Models;

namespace trilha_net_api_desafio.Context
{
    public class DiarioContext : DbContext
    {
        public DiarioContext(DbContextOptions<DiarioContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}