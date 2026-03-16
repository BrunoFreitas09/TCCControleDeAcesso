using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCCControleDeAcesso.Data;
using TCCControleDeAcesso.Models;
using TCCControleDeAcesso.Views;
using static TCCControleDeAcesso.Data.DbConnection;

namespace TCCControleDeAcesso.Controllers
{
    public class Login
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public int idEscola { get; set; }

        public string HashBanco { get; set; }

        public int count;



        public void LoginPermissions()
        {
            try
            {
                //Banco.Command = new MySqlCommand("select id from escolas where email=@email", Banco.Connection);
                //Banco.Command.Parameters.AddWithValue("@email", email);

                //using (MySqlDataReader reader = Banco.Command.ExecuteReader())
                //{
                //    if (reader.Read())
                //    {
                //        idEscola = reader.GetInt32("id"); // aqui era um GetInt32 antes
                //    }
                //}
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao guardar o id ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PullSenha()
        {
            try
            {
                using (var context = new AccessControl())
                {
                    var escola = context.escola
                        .Where(e => e.Email == email)
                        .Select(e => e.Senha)
                        .FirstOrDefault();

                    if (escola != null)
                    {
                        HashBanco = escola;
                        count = 1;
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao guardar o id ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        
    }
}


