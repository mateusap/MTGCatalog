using MTGCatalog.Services;
using RestSharp.Serialization.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static MTGCatalog.Services.CardModel;

namespace MTGCatalog
{
    public partial class FormNome : Form
    {
        private APIService APISearch;
        public FormNome()
        {
            InitializeComponent();
            DoubleBuffered = true;
            APISearch = new APIService();
            listBox1.Visible = false;
            btnFnNome.Enabled = false;

        }
        private void btnFnNome_Click(object sender, EventArgs e)
        {
            ResultadoNomeAsync();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var lista = ((CardFace)listBox1.SelectedItem);
            txtNomeR.Text = lista.name;
            txtCmcR.Text = lista.mana_cost;
            richTextR.Text = lista.oracle_text;
            try
            {
                txtCorR.Text = String.Join(", ", lista.colors);
                pBoxCard.LoadAsync(lista.image_uris.small);
            }
            catch
            {
                txtCorR.Text = txtCmcR.Text;
                pBoxCard.Image = pBoxCard.Image;
            }
        }

        private void tBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxNome.Text))
            {
                btnFnNome.Enabled = false;
            }
            else
            {
                btnFnNome.Enabled = true;
            }
        }
        private async void ResultadoNomeAsync()
        {
            var resultado = await APISearch.GetCardAsync(tBoxNome.Text);

            if (resultado.card_faces == null)
            {
                listBox1.Visible = false;
                txtNomeR.Text = resultado.name;
                txtCmcR.Text = resultado.mana_cost;
                txtSetR.Text = resultado.set__name;
                txtRarityR.Text = resultado.rarity.ToUpper();
                richTextR.Text = resultado.oracle_text;
                txtCorR.Text = String.Join(", ", resultado.colors);
                pBoxCard.LoadAsync(resultado.image_uris.small);

            }
            else
            {
                listBox1.Visible = true;
                listBox1.DataSource = resultado.card_faces;
                listBox1.DisplayMember = "Name";
                var cardface = resultado.card_faces[0];
                txtNomeR.Text = cardface.name;
                txtCmcR.Text = cardface.mana_cost;
                txtSetR.Text = resultado.set__name;
                txtRarityR.Text = resultado.rarity.ToUpper();
                richTextR.Text = cardface.oracle_text;
                try
                {
                    txtCorR.Text = String.Join(", ", cardface.colors);
                    pBoxCard.LoadAsync(cardface.image_uris.small);
                }
                catch
                {
                    txtCorR.Text = String.Join(", ", resultado.colors);
                    pBoxCard.LoadAsync(resultado.image_uris.small);
                }
            }
        }

        private void tBoxNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFnNome_Click(this, new EventArgs());
            }
        }
    }
}
