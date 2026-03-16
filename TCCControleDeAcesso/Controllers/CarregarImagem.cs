using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCCControleDeAcesso.Data;
using TCCControleDeAcesso.Models;
using static TCCControleDeAcesso.Data.DbConnection;

namespace TCCControleDeAcesso.Controllers
{
    public class CarregarImagem
    {
        public void LoadImage(string nomeAluno)
        {
            try
            {
                using (var context = new AccessControl())
                {
                    var aluno = context.alunos
                        .FirstOrDefault(a => a.Name == nomeAluno);
                }
                //Banco.Connection.Open();
                //Banco.Command = new MySqlCommand("SELECT foto FROM alunos WHERE nome = @nome", Banco.Connection);
                //Banco.Command.Parameters.AddWithValue("@nome", nomeAluno);
                

            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }
        }
    }
}
