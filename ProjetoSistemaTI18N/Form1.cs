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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }// faz o carregamento de conteúdos da minha tela

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }// fim do casdastrar

        private void Consultar_Click(object sender, EventArgs e)
        {

        }// fim do consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {

        }// fim do atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {

        }// fim do Excluir

        
    }//fim da clase
}//fim do projeto 
