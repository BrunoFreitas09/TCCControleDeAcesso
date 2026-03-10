using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TCCControleDeAcesso.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TCCControleDeAcesso.Controllers
{
    public class backup
    {


        public void Insert(int _idEscola)
        {
            var curso = new Curso();
            try
            {
                Banco.OpenConnection();
                Banco.Command = new MySqlCommand("insert into cursos(nome, idEscola) values(@Nome, @IdEscola)", Banco.Connection);
                Banco.Command.Parameters.AddWithValue("@Nome", curso.Name);
                Banco.Command.Parameters.AddWithValue("@idEscola", _idEscola);
                Banco.Command.ExecuteNonQuery();
                Banco.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro Ao Inserir Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ListCourses(int _idEscola)
        {
            try
            {
                Banco.OpenConnection();
                Banco.Command = new MySqlCommand("select id, nome from cursos where idEscola=@idEscola", Banco.Connection);
                Banco.Command.Parameters.AddWithValue("@idEscola", _idEscola);
                Banco.DataAdapter = new MySqlDataAdapter(Banco.Command);
                Banco.datTable = new DataTable();
                Banco.DataAdapter.Fill(Banco.datTable);
                Banco.CloseConnection();
                return Banco.datTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro Ao Listar Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Delete()
        {
            try
            {
                var curso = new Curso();
                Banco.OpenConnection();
                Banco.OpenConnection();
                Banco.Command = new MySqlCommand("delete from cursos where id = @id", Banco.Connection);
                Banco.Command.Parameters.AddWithValue("@id", curso.Id);
                Banco.Command.ExecuteNonQuery();
                Banco.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro Ao Deletar Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //public void Update()
        //{
        //    try
        //    {
        //        var curso = new Curso();
        //        Banco.OpenConnection();
        //        Banco.Command = new MySqlCommand("update Alunos set nome = @nome where id = @id", Banco.Connection);
        //        Banco.Command.Parameters.AddWithValue("@id", curso.Id);
        //        Banco.Command.ExecuteNonQuery();
        //        Banco.CloseConnection();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Erro Ao Atualizar Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    public void Insert()
        //{
        //    try
        //    {
        //        Banco.OpenConnection();

        //        Banco.Command = new MySqlCommand("insert into escolas(id, nome, email,senha) " +
        //            "values(@id, @nome,@email, @senha)", Banco.Connection);
        //        Banco.Command.Parameters.AddWithValue("@id", Id);
        //        Banco.Command.Parameters.AddWithValue("@nome", Name.Trim());
        //        Banco.Command.Parameters.AddWithValue("@email", Email.Trim());
        //        Banco.Command.Parameters.AddWithValue("@senha", Senha.Trim());
        //        Banco.Command.ExecuteNonQuery();


        //        Banco.CloseConnection();


        //    }
        //    catch (Exception e)
        //    {

        //        MessageBox.Show(e.Message, "Erro Ao Inserir Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //}

        //public void Update()
        //{
        //    try
        //    {
        //        Banco.OpenConnection();
        //        Banco.Command = new MySqlCommand("update escolas set nome = @nome, email=@email, senha=@senha where id = @id", Banco.Connection);
        //        Banco.Command.Parameters.AddWithValue("@id", Id);
        //        Banco.Command.Parameters.AddWithValue("@nome", Name.Trim());
        //        Banco.Command.Parameters.AddWithValue("@email", Email.Trim());
        //        Banco.Command.Parameters.AddWithValue("@senha", Senha.Trim());

        //        Banco.Command.ExecuteNonQuery();
        //        Banco.CloseConnection();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "Erro Ao Atualizar Dados!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        ////possivel caca a ser feita(Eu Bruno vou fazer uma função para uxar a senha do nosso banco de dados)

        //public void PullSenha()
        //{
        //    try
        //    {
        //        Banco.OpenConnection();
        //        string HashBanco = null;

        //        using (var cmd = new MySqlCommand("SELECT senha FROM escolas WHERE Email = @email ", Banco.Connection))
        //        {
        //            cmd.Parameters.AddWithValue("@email", Email);

        //            var result = cmd.ExecuteScalar(); // pega o primeiro valor da consulta

        //            if (result != null)
        //            {
        //                HashBanco = result.ToString(); // senha (hash) armazenada no banco
        //            }
        //        }
        //        Banco.CloseConnection();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Algo deu errado na conexão com o banco.");
        //    }
        //}
    } 

}
