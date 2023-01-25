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
                txtTipo.Text = lista.type_line;
                txtCorR.Text = String.Join(", ", lista.colors);
                pBoxCard.LoadAsync(lista.image_uris.small);
            }
            catch
            {
                txtTipo.Text = txtTipo.Text;
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

            listEfeito.DataSource = resultado.data;
            listEfeito.DisplayMember = "Name";
            qtResultado.Text = $"{listEfeito.Items.Count.ToString()} resultados.";
        }
        private void listEfeito_DoubleClick(object sender, EventArgs e)
        {
            var lista = ((Datum)listEfeito.SelectedItem);
            if (lista.card_faces == null)
            {
                listBox1.Visible = false;
                txtNomeR.Text = lista.name;
                txtCmcR.Text = lista.cmc.ToString();
                txtTipo.Text = lista.type_line;
                txtCorR.Text = String.Join(", ", lista.colors.Select(x => x));
                txtSetR.Text = lista.set__name;
                txtRarityR.Text = lista.rarity.ToUpper();
                richTextR.Text = lista.oracle_text;
                pBoxCard.LoadAsync(lista.image_uris.small);
            }
            else
            {
                listBox1.Visible = true;
                listBox1.DataSource = lista.card_faces;
                listBox1.DisplayMember = "Name";
                var cardface = lista.card_faces[0];
                txtNomeR.Text = cardface.name;
                txtCmcR.Text = cardface.mana_cost;
                txtTipo.Text = cardface.type_line;
                txtSetR.Text = lista.set__name;
                txtRarityR.Text = lista.rarity.ToUpper();
                richTextR.Text = cardface.oracle_text;
                try
                {
                    txtCorR.Text = String.Join(", ", cardface.colors);
                    pBoxCard.LoadAsync(cardface.image_uris.small);
                }
                catch
                {
                    txtCorR.Text = String.Join(", ", lista.colors);
                    pBoxCard.LoadAsync(lista.image_uris.small);
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

        private void tBoxNome_Enter(object sender, EventArgs e)
        {
            if (tBoxNome.Text == "Digite o nome da carta")
            {
                tBoxNome.Text = "";
                tBoxNome.ForeColor = Color.Black;
            }
        }

        private void tBoxNome_Leave(object sender, EventArgs e)
        {
            if (tBoxNome.Text == "")
            {
                tBoxNome.Text = "Digite o nome da carta";
                tBoxNome.ForeColor = Color.LightGray;
            }
        }
    }
}
