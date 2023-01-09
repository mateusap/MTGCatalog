using MTGCatalog.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGCatalog
{
    public partial class FormEfeito : Form
    {
        private Services.APIService APISearch;
        public FormEfeito()
        {
            InitializeComponent();
            APISearch = new APIService();
            listBox1.Visible = false;
            btnFnEfeito.Enabled = false;
        }
        private void btnFnEfeito_Click(object sender, EventArgs e)
        {
            ResultadoEfeito(APISearch.GetByEffect(tBoxEfeito.Text));
        }

        private void listEfeito_DoubleClick(object sender, EventArgs e)
        {
            var lista = ((CardModel.Datum)listEfeito.SelectedItem);
            if (lista.card_faces == null)
            {
                listBox1.Visible = false;
                txtNomeR.Text = lista.name;
                txtCmcR.Text = lista.cmc.ToString();
                txtCorR.Text = String.Join(", ", lista.colors.Select(x => x));
                txtSetR.Text = lista.set__name;
                txtRarityR.Text = lista.rarity.ToUpper();
                richTextR.Text = lista.oracle_text;
                pBoxCard.Load(lista.image_uris.normal);
            }
            else
            {
                listBox1.Visible = true;
                listBox1.DataSource = lista.card_faces;
                listBox1.DisplayMember = "Name";
                var cardface = lista.card_faces[0];
                txtNomeR.Text = cardface.name;
                txtCmcR.Text = cardface.mana_cost;
                txtSetR.Text = lista.set__name;
                txtRarityR.Text = lista.rarity.ToUpper();
                richTextR.Text = cardface.oracle_text;
                try
                {
                    txtCorR.Text = String.Join(", ", cardface.colors);
                    pBoxCard.Load(cardface.image_uris.normal);
                }
                catch
                {
                    txtCorR.Text = String.Join(", ", lista.colors);
                    pBoxCard.Load(lista.image_uris.normal);
                }
            }
        }

        private void ResultadoEfeito(CardModel.Root resultado)
        {
            var carta = APISearch.GetByEffect(tBoxEfeito.Text);
            listEfeito.DataSource = carta.data;
            listEfeito.DisplayMember = "Name";
            qtResultado.Text = $"{listEfeito.Items.Count.ToString()} resultados.";
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

        private void tBoxEfeito_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxEfeito.Text))
            {
                btnFnEfeito.Enabled = false;
            }
            else
            {
                btnFnEfeito.Enabled = true;
            }
        }
    }
}
