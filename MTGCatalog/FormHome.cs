using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MTGCatalog
{
    public partial class FormHome : Form
    {
        public const int WM_NCLBUTTODOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public FormHome()
        {
            InitializeComponent();
            btnRestaurar.Visible = false;
            pnlCorCMC.Visible = false;
            pnlEfeito.Visible = false;
            pnlNome .Visible = false;
            pnlStatus .Visible = false;
            pnlTipo .Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTODOWN, HT_CAPTION, 0);
            }
        }

        private void btnBuscaNome_Click(object sender, EventArgs e)
        {
            pnlNome.Visible = true;
        }

        private void btnBuscaEfeito_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaCorCMC_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscaTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
