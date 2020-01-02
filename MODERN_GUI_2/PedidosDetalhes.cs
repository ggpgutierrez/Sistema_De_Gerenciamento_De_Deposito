using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class PedidosDetalhes : MaterialForm
    {
        public PedidosDetalhes()
        {
            InitializeComponent();
            
                  var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.LightBlue200,
                TextShade.WHITE);
           
        }

        private void PedidosDetalhes_Load(object sender, EventArgs e)
        {
            ControladorPedido controladorPedido = new ControladorPedido();
            DataSet dataSet = new DataSet();
            dataSet = controladorPedido.retornaItensPedido(txtid.Text);
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = dataSet.Tables[0].TableName;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ControladorPedido controladorPedido = new ControladorPedido();
            controladorPedido.atualisaStatus(txtid.Text, Status.SelectedItem.ToString());
        }
    }
}
