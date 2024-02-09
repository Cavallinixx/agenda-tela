using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistemaTI18N
{
    public partial class Cadastrar : Form

       
    {
        DAO bd;

        public Cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void codigo_Click(object sender, EventArgs e)
        {

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }//fim do nome

        private void telefone_Click(object sender, EventArgs e)
        {

        }// fim do telefone

        private void cidade_Click(object sender, EventArgs e)
        {

        }// fim da cidade

        private void estado_Click(object sender, EventArgs e)
        {

        }// fim do estado

        private void cadastrarbotao_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(maskedTextBox2.Text);
            string name = nome.Text;
            string tel = telefone.Text;
            string cid = cidade.Text;
            string est = estado.Text;

            bd.Inserir(cod, name, tel, cid, est);//Inserindo no BD
        }//fim do cadastrar botao

        private void voltar_Click(object sender, EventArgs e)
        {

        }// fim do voltar
    }
}
