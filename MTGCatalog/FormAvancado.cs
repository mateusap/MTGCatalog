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
using static MTGCatalog.Services.CompareAndTypes;

namespace MTGCatalog
{
    public partial class FormAvancado : Form
    {
        private APIService APISearch;
        private CompareAndTypes CompareAndTypes;
        public FormAvancado()
        {
            InitializeComponent();
            DoubleBuffered = true;
            APISearch = new APIService();
            CompareAndTypes = new CompareAndTypes();
            listBox1.Visible = false;

            cbTipos.DataSource = CompareAndTypes.ShowTypes();
            cbTipos.DisplayMember = "typeDisplay";
            cbTipos.ValueMember = "typeUrl";

            ((ListBox)cListCores).DataSource = CompareAndTypes.ShowColors();
            ((ListBox)cListCores).DisplayMember = "corDisplay";
            ((ListBox)cListCores).ValueMember = "corUrl";

            cBoxCorIndic.DataSource = CompareAndTypes.ShowColorIndic();
            cBoxCorIndic.DisplayMember = "colorIndicDisplay";
            cBoxCorIndic.ValueMember = "colorIndicUrl";

            cBoxCmc.DataSource = CompareAndTypes.ShowCompare();
            cBoxCmc.DisplayMember = "compareDisplay";
            cBoxCmc.ValueMember = "compareUrl";

            cBoxPoder.DataSource = CompareAndTypes.ShowCompare();
            cBoxPoder.DisplayMember = "compareDisplay";
            cBoxPoder.ValueMember = "compareUrl";

            cBoxResist.DataSource = CompareAndTypes.ShowCompare();
            cBoxResist.DisplayMember = "compareDisplay";
            cBoxResist.ValueMember = "compareUrl";

            cBoxLoyal.DataSource = CompareAndTypes.ShowCompare();
            cBoxLoyal.DisplayMember = "compareDisplay";
            cBoxLoyal.ValueMember = "compareUrl";
            comboBox1.SelectedIndex = 0;
        }

        private void btnFnBusca_Click(object sender, EventArgs e)
        {
            ResultadoAsync();
        }

        private async void ResultadoAsync()
        {
            string par = Busca();
            var resultado = await APISearch.GetByAdvancedAsync(par);
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
        private string Busca()
        {
            string nome;
            if (tBoxNome.Text == "Digite o nome da carta")
            {
                nome = "";
            }
            else
                nome = ($"{tBoxNome.Text}+");

            string efeito;
            if (tBoxEfeito.Text == "Digite parte do texto")
            {
                efeito = "";
            }
            else
                efeito = ($"o:{tBoxEfeito.Text}+");

            string tipo;
            if (cbTipos.SelectedIndex == 0)
            {
                tipo = "";
            }
            else tipo = ($"t:{cbTipos.SelectedValue.ToString()}+");

            string cor;
            if (cListCores.SelectedItems.Count == 0)
            {
                cor = "";
            }
            else 
            {
                var listacor = this.cListCores.CheckedItems.Cast<Cores>().Select(x => x.corUrl);
                string cores = String.Join("", listacor);
                cor = ($"c{cBoxCorIndic.SelectedValue}{cores}+cmc{cBoxCmc.SelectedValue}{txtCusto.Text}");
            }



            string parametro = nome+efeito+tipo+cor;
            return parametro;
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
        private void txtCusto_Enter(object sender, EventArgs e)
        {
            if (txtCusto.Text == "Custo")
            {
                txtCusto.Text = "";
                txtCusto.ForeColor = Color.Black;
            }
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            if (txtCusto.Text == "")
            {
                txtCusto.Text = "Custo";
                txtCusto.ForeColor = Color.LightGray;
            }
        }
        private void cbTipos_KeyDown(object sender, KeyEventArgs e)
        {
            cbTipos.DroppedDown = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    txtLoyal.Visible = false;
                    txtPoder.Visible = false;
                    txtResist.Visible = false;
                    cBoxLoyal.Visible = false;
                    cBoxPoder.Visible = false;
                    cBoxResist.Visible = false;
                    break;
                case 1:
                    txtPoder.Visible = true;
                    txtResist.Visible = true;
                    txtLoyal.Visible = false;
                    cBoxLoyal.Visible = false;
                    cBoxPoder.Visible = true;
                    cBoxResist.Visible = true;
                    break;
                case 2:
                    txtLoyal.Visible = true;
                    txtPoder.Visible = false;
                    txtResist.Visible = false;
                    cBoxLoyal.Visible = true;
                    cBoxPoder.Visible = false;
                    cBoxResist.Visible = false;
                    break;
            }
        }

        private void txtPoder_Enter(object sender, EventArgs e)
        {
            if (txtPoder.Text == "Poder")
            {
                txtPoder.Text = "";
                txtPoder.ForeColor = Color.Black;
            }
        }

        private void txtPoder_Leave(object sender, EventArgs e)
        {
            if (txtPoder.Text == "")
            {
                txtPoder.Text = "Poder";
                txtPoder.ForeColor = Color.LightGray;
            }
        }

        private void txtResist_Enter(object sender, EventArgs e)
        {
            if (txtResist.Text == "Resist.")
            {
                txtResist.Text = "";
                txtResist.ForeColor = Color.Black;
            }
        }

        private void txtResist_Leave(object sender, EventArgs e)
        {
            if (txtResist.Text == "")
            {
                txtResist.Text = "Resist.";
                txtResist.ForeColor = Color.LightGray;
            }
        }

        private void txtLoyal_Enter(object sender, EventArgs e)
        {
            if (txtLoyal.Text == "Lealdade")
            {
                txtLoyal.Text = "";
                txtLoyal.ForeColor = Color.Black;
            }
        }

        private void txtLoyal_Leave(object sender, EventArgs e)
        {
            if (txtLoyal.Text == "")
            {
                txtLoyal.Text = "Lealdade";
                txtLoyal.ForeColor = Color.LightGray;
            }
        }
        private void tBoxEfeito_Enter(object sender, EventArgs e)
        {
            if (tBoxEfeito.Text == "Digite parte do texto")
            {
                tBoxEfeito.Text = "";
                tBoxEfeito.ForeColor = Color.Black;
            }
        }

        private void tBoxEfeito_Leave(object sender, EventArgs e)
        {
            if (tBoxEfeito.Text == "")
            {
                tBoxEfeito.Text = "Digite parte do texto";
                tBoxEfeito.ForeColor = Color.LightGray;
            }
        }
    }
}
