using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCCControleDeAcesso.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int idEscola { get; set; }

        public DataTable ListCourses(int _idEscola)
        {
            //try
            //{
            //    Banco.OpenConnection();
            //    Banco.Command = new MySqlCommand("select id, nome from cursos where idEscola=@idEscola", Banco.Connection);
            //    Banco.Command.Parameters.AddWithValue("@idEscola", _idEscola);
            //    Banco.DataAdapter = new MySqlDataAdapter(Banco.Command);
            //    Banco.datTable = new DataTable();
            //    Banco.DataAdapter.Fill(Banco.datTable);
            //    Banco.CloseConnection();
            //    return Banco.datTable;
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message, "Erro Ao Listar Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
            return null;
        }
    }

}
