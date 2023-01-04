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
    public partial class FormNome : Form
    {
        private Services.APIService APISearch;
        public FormNome()
        {
            InitializeComponent();
            APISearch = new APIService();

        }
        private void btnFnNome_Click(object sender, EventArgs e)
        {
            ResultadoNome(APISearch.GetCard(tBoxNome.Text));
        }

        private void ResultadoNome(CardModel.Datum resultado)
        {
            txtNomeR.Text = resultado.name;
            txtCmcR.Text = resultado.cmc.ToString();
            txtCorR.Text = String.Join(", ", resultado.colors);
            txtSetR.Text = resultado.set__name;
            txtRarityR.Text = resultado.rarity.ToUpper();
            richTextR.Text = resultado.oracle_text;
            pBoxCard.Load(resultado.image_uris.normal);
        }

        
    }
}
