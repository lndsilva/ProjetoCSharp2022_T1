using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCSharp
{

    public partial class frmDadosPessoais : Form
    {
        //declarando variável global
        bool flag = false;

        public frmDadosPessoais()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           // flag = true;
            Close();
            // sexo = 'M';
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //declarando variável local ao método
            string mensagem = "Deseja sair do sistema?";
            string titulo = "Sistema de cadastro";

            MessageBoxButtons botao = MessageBoxButtons.YesNoCancel;

            //Criando a caixa de mensagem para interagir com o usuário

            MessageBox.Show("Deseja sair do sistema?","Sistema de Cadastro",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button3);


        }

        char sexo = 'F';
    }
}
