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
    public partial class FormStatus : Form
    {
        private CompareAndTypes CompareAndTypes;
        private APIService APISearch;
        public FormStatus()
        {
            InitializeComponent();
            DoubleBuffered = true;
            APISearch = new APIService();
            CompareAndTypes = new CompareAndTypes();
            cBoxPoder.DataSource = CompareAndTypes.ShowCompare();
            cBoxPoder.DisplayMember = "compareDisplay";
            cBoxPoder.ValueMember = "compareUrl";
            cBoxResist.DataSource = CompareAndTypes.ShowCompare();
            cBoxResist.DisplayMember = "compareDisplay";
            cBoxResist.ValueMember = "compareUrl";
            cBoxLoyal.DataSource = CompareAndTypes.ShowCompare();
            cBoxLoyal.DisplayMember = "compareDisplay";
            cBoxLoyal.ValueMember = "compareUrl";
        }

        private void btnFnStatus_Click(object sender, EventArgs e)
        {
            ResultadoStatusAsync();
            txtLoyal.Text = "";
            txtPoder.Text = "";
            txtResist.Text = "";
        }

        private async void ResultadoStatusAsync()
        {
            if (string.IsNullOrEmpty(txtLoyal.Text))
            {
                string poder = $"pow{cBoxPoder.SelectedValue}{txtPoder.Text}+";
                string resist = $"tou{cBoxResist.SelectedValue}{txtResist.Text}";
                string parametro = $"{poder}{resist}";
                var resultado = await APISearch.GetByStatusAsync(parametro);
                listEfeito.DataSource = resultado.data;
                listEfeito.DisplayMember = "Name";
                qtResultado.Text = $"{listEfeito.Items.Count.ToString()} resultados.";
            }
            else
            {
                var resultado = await APISearch.GetByStatusAsync($"loy{cBoxLoyal.SelectedValue}{txtLoyal.Text}");
                listEfeito.DataSource = resultado.data;
                listEfeito.DisplayMember = "Name";
                qtResultado.Text = $"{listEfeito.Items.Count.ToString()} resultados.";
            }
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

        private void txtPoder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFnStatus_Click(this, new EventArgs());
            }
        }

        private void txtResist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFnStatus_Click(this, new EventArgs());
            }
        }
    }
}
