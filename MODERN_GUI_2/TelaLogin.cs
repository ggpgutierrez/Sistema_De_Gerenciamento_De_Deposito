using MaterialSkin;
using MaterialSkin.Controls;
using MODERN_GUI_2.Auxiliar;
using MODERN_GUI_2.Controller;
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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            
        }

     

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            ControladorLogar controladorLogar = new ControladorLogar();
            if (controladorLogar.Autenticar(user))
            {
                this.Hide();
            }
        }
    }
}
