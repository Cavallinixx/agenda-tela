using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoSistemaTI18N
{
    internal class DAO
    {
        MySqlConnection conexao;
        public string dados;
        public string sql;

        public DAO() 
        {
            conexao = new MySqlConnection("server=local-host;DataBase=ti18n;Uid=root;Password=");
            try 
            {
                conexao.Open();
                MessageBox.Show("Conectado com sucesso!");
            }catch(Exception erro) 
            { 
                MessageBox.Show(erro + "\n\nAlgo deu errado!");

            }//fim do catch

        }//fim do DAO

        public void Inserir(int codigo, string nome,string telefone,string cidade, string estado)
        {
            dados = "('" + codigo + "','" + nome + "','" + telefone + "','" + cidade + "','" + estado + "')";
            sql = "insert into pessoa(codigo,nome,telefone,cidade,estado) values" + dados;
            try
            {


                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show("1 Dado Inserido" + conn.ExecuteNonQuery() + "dado inserido!");
            }catch(Exception erro) 
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
            }//fim do metodo
    }//fim da classe
}//fim do projeto 
