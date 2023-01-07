using MTGCatalog.Services;
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
        private Services.APIService APISearch;
        public FormNome()
        {
            InitializeComponent();
            APISearch = new APIService();
            listBox1.Visible = false;
            btnFnNome.Enabled = false;
        }
        private void btnFnNome_Click(object sender, EventArgs e)
        {
            ResultadoNome(APISearch.GetCard(tBoxNome.Text));
        }

        private void ResultadoNome(CardModel.Datum resultado)
        {
            if (resultado.card_faces == null)
            {
                listBox1.Visible = false;
                txtNomeR.Text = resultado.name;
                txtCmcR.Text = resultado.mana_cost;
                txtSetR.Text = resultado.set__name;
                txtRarityR.Text = resultado.rarity.ToUpper();
                richTextR.Text = resultado.oracle_text;
                txtCorR.Text = String.Join(", ", resultado.colors);
                pBoxCard.Load(resultado.image_uris.normal);
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
                    pBoxCard.Load(cardface.image_uris.normal);
                }
                catch
                {
                    txtCorR.Text = String.Join(", ", resultado.colors);
                    pBoxCard.Load(resultado.image_uris.normal);
                }
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var lista = ((CardModel.CardFace)listBox1.SelectedItem);
            txtNomeR.Text = lista.name;
            txtCmcR.Text = lista.mana_cost;
            richTextR.Text = lista.oracle_text;
            try
            {
                txtCorR.Text = String.Join(", ", lista.colors);
                pBoxCard.Load(lista.image_uris.normal);
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
    }
}
