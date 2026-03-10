using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TCCControleDeAcesso.Models;


namespace TCCControleDeAcesso
{
    public class DbConnection
    {
        public class AcessControl : DbContext
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
