using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CatalogoFilmes
{
    public partial class FormFilmes : Form
    {
        public Usuario usuario;
        public FormFilmes(Usuario u)
        {
            InitializeComponent();
            this.usuario = u;
        }

        private void FormFilmes_Load(object sender, EventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.Length > 0)
            {
                Filme filme = new Filme(tbNome.Text, "", 0, 0, "", "", "");
                if (cbAssistido.Checked)
                {
                    usuario.filmesAssistidos.Add(filme);
                    AdicionarNaListView(lvAssistidos, filme);

                }
                else
                {
                    usuario.filmesParaAssistir.Add(filme);
                    AdicionarNaListView(lvAssistir, filme);
                }
                LimparCampos();
            }
            else
            {
                MessageBox.Show("O campo nome está vazio!");
            }
        }
        private void AdicionarNaListView(ListView listView, Filme f)
        {
            ListViewItem item = new ListViewItem(listView.Items.Count.ToString());
            item.SubItems.Add(f.nome);
            //item.SubItems.Add(f.genero); ....
            listView.Items.Add(item);
        }
        private void LimparCampos()
        {
            tbNome.Text = "";
            //....
            cbAssistido.Checked = false;
        }


    }
}
