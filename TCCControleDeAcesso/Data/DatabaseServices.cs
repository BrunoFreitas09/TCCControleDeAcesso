using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TCCControleDeAcesso.Models;
using TCCControleDeAcesso.Controllers;


namespace TCCControleDeAcesso.Data
{
    public class DbConnection
    {
        public class AccessControl : DbContext
        {

            public AcessControl() : base("name=AcessControl")
            {
            }

            public DbSet<Escola> escola { get; set; }
            public DbSet<CadastroAlunos> alunos { get; set; }
            public DbSet<Curso> cursos { get; set; }
            public DbSet<Entrada> entradas { get; set; }
            
            
        }

    }
}
