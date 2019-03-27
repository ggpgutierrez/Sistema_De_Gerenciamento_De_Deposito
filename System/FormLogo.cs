using MODERN_GUI_2.Controller;
using System;
using System.Windows.Forms;

namespace MODERN_GUI_2
{
    public partial class FormLogo : Form
    {
        public FormLogo()
        {
            InitializeComponent();
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }

        private void FormLogo_Load(object sender, EventArgs e)
        {
            ControladorProduto controladorProduto = new ControladorProduto();

            timer1.Enabled = true;
            lblValorSemanal.Text = "R$ " + controladorProduto.caixaSemanal();
            lblCategorias.Text = controladorProduto.contarCategorias();
            lblProdutos.Text = controladorProduto.contarProdutos();
            lblFim.Text = controladorProduto.contarProdutosFim();
            lblDia.Text = "R$ "+controladorProduto.caixaDia();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
