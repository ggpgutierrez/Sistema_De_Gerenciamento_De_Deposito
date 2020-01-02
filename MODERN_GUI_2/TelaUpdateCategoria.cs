using MaterialSkin;
using MaterialSkin.Controls;
using MODERN_GUI_2.Controller;
using MODERN_GUI_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2
{
    public partial class TelatUpdateCategoria : MaterialForm
    {
        public TelatUpdateCategoria()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void TelaUpdateCategoria_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.idCategoria = Convert.ToInt16(txtId.Text);
            categorias.Categoria = txtCategoria.Text;
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            if (controladorCategoria.atualizarCategoria(categorias))
            {
                this.Close();
            }
        }
    }
}
