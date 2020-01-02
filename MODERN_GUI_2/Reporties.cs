using MaterialSkin;
using MaterialSkin.Controls;
using MODERN_GUI_2.Controller;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MODERN_GUI_2
{
    public partial class Reporties : MaterialForm
    {
        public Reporties()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.LightBlue200,
                TextShade.WHITE);

        }
        public void dgv(int btn, String data)
        {
            ControladorPedido controladorPedido = new ControladorPedido();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet datas = new DataSet();
            datas = controladorPedido.retornaTotal(btn, data);
            dgvResposta.DataSource = datas;
            dgvResposta.DataMember = datas.Tables[0].TableName;
        }
        private void Reporties_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAno_Click(object sender, EventArgs e)
        {
            String data = txtAno.Text;
            dgv(2, data);
        }

        private void BtnEspecifico_Click(object sender, EventArgs e)
        {
            String data = especifica.Text;
            DateTime data2;
         
                data2 = Convert.ToDateTime(data);
                data = data2.ToString("yyyy-MM-dd");
           
            dgv(1, data);
        }

        private void BtnMes_Click(object sender, EventArgs e)
        {
            String data = mes.Text;
            dgv(3, data);
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            dgv(4, null);
        }

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
