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

namespace MODERN_GUI_2
{
    public partial class FormListaPedidos : MaterialForm
    {
        public FormListaPedidos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.LightBlue200,
                TextShade.WHITE);
            dgv();
        }

        private void FormListaPedidos_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void dgv()
        {
            ControladorPedido controladorProduto = new ControladorPedido();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataSet = new DataSet();
            dataSet = controladorProduto.retorna();
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = dataSet.Tables[0].TableName;
        }
        public void atualizar()
        {
            PedidosDetalhes frm = new PedidosDetalhes();
            frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Status.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        

            frm.ShowDialog();
            dgv();
        }
        public void dgvFiltro()
        {
            if (Filtro.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Selecione uma forma de filtro");

            }
            else if (Filtro.SelectedItem.ToString() == "Hoje")
            {
                string Date = DateTime.Now.ToString("yyyy-MM-dd");
                ControladorPedido controladorPedido = new ControladorPedido();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet dataSet = new DataSet();
                string filtro = Filtro.SelectedItem.ToString();
                dataSet = controladorPedido.retornaFiltro(filtro, Date);
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = dataSet.Tables[0].TableName;
            }else
            {
               
                ControladorPedido controladorPedido = new ControladorPedido();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet dataSet = new DataSet();
                string filtro = Filtro.SelectedItem.ToString();
                string texto = materialSingleLineTextField1.Text;
                dataSet = controladorPedido.retornaFiltro(filtro, texto);
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = dataSet.Tables[0].TableName;
            }
        }

        private void Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFiltro();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvFiltro();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            atualizar();
        }
    }
}
