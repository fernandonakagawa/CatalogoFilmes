using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogoFilmes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            if(Banco.CriarUsuario(tbLogin.Text, tbSenha.Text))
            {
                MessageBox.Show($"Usuário {tbLogin.Text} criado com sucesso!");
            }
            else
            {
                MessageBox.Show($"Erro ao criar usuário {tbLogin.Text}! Login já existente.");
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Usuario u = Banco.RealizarLogin(tbLogin.Text, tbSenha.Text);
            if(u == null)
            {
                MessageBox.Show("Erro ao realizar login. Usuário ou senha não conferem!");
            }
            else
            {
                FormFilmes formFilmes = new FormFilmes(u);
                formFilmes.Show();
                this.Hide();
            }
        }
    }
}
