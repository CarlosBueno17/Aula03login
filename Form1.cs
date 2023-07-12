using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;

            usuario=txtUsuario.Text;
            senha=txtSenha.Text;

            if(usuario== "Cadu" && senha == "senha123") 
            {
                MessageBox.Show("Você se conectou!");
                panelSaldo.Visible = true;
            }
            else
            {
                MessageBox.Show("Esta incorreto");
            }
        }
    }
}
