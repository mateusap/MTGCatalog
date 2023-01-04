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
        }
        private void btnFnEfeito_Click(object sender, EventArgs e)
        {
            ResultadoEfeito(APISearch.GetByEffect(tBoxEfeito.Text));
        }

        private void listEfeito_DoubleClick(object sender, EventArgs e)
        {
            var lista = ((CardModel.Datum)listEfeito.SelectedItem);
            txtNomeR.Text = lista.name;
            txtCmcR.Text = lista.cmc.ToString();
            txtCorR.Text = String.Join(", ", lista.colors.Select(x => x));
            txtSetR.Text = lista.set__name;
            txtRarityR.Text = lista.rarity.ToUpper();
            richTextR.Text = lista.oracle_text;
            pBoxCard.Load(lista.image_uris.normal);
        }

        private void ResultadoEfeito(CardModel.Root resultado)
        {
            var carta = APISearch.GetByEffect(tBoxEfeito.Text);
            listEfeito.DataSource = carta.data;
            listEfeito.DisplayMember = "Name";
        }
    }
}
