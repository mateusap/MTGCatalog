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
using static MTGCatalog.Services.CardModel;

namespace MTGCatalog
{
    public partial class FormTipo : Form
    {
        private CompareAndTypes CompareAndTypes;
        private APIService APISearch;
        public FormTipo()
        {
            InitializeComponent();
            DoubleBuffered = true;
            APISearch = new APIService();
            CompareAndTypes = new CompareAndTypes();
            listBox1.Visible = false;
            cbTipos.DataSource = CompareAndTypes.ShowTypes();
            cbTipos.DisplayMember = "typeDisplay";
            cbTipos.ValueMember = "typeUrl";
        }

        private void btnFnTipo_Click(object sender, EventArgs e)
        {
            ResultadoTipoAsync();
        }

        private async void ResultadoTipoAsync()
        {
            var resultado = await APISearch.GetByTypeAsync(cbTipos.SelectedValue.ToString());
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
                pBoxCard.Load(lista.image_uris.small);
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
                    pBoxCard.Load(cardface.image_uris.small);
                }
                catch
                {
                    txtCorR.Text = String.Join(", ", lista.colors);
                    pBoxCard.Load(lista.image_uris.small);
                }
            }
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
                pBoxCard.Load(lista.image_uris.small);
            }
            catch
            {
                txtTipo.Text = txtTipo.Text;
                txtCorR.Text = txtCmcR.Text;
                pBoxCard.Image = pBoxCard.Image;
            }
        }

        private void cbTipos_KeyDown(object sender, KeyEventArgs e)
        {
            cbTipos.DroppedDown = false;
        }
    }
}
