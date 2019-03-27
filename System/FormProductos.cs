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
    public partial class FormProductos : MaterialForm
    {
        public FormProductos()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.LightBlue200,
                TextShade.WHITE);
            Filtro.SelectedItem = "Categoria";
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            dgv();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantProducto frm = new FormMantProducto();
            frm.ShowDialog();
            dgv();
        }

            public void dgv()
            {
                ControladorProduto controladorProduto = new ControladorProduto();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataSet dataSet = new DataSet();
                dataSet = controladorProduto.retorna();
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = dataSet.Tables[0].TableName;
            }
        public void atualizar()
        {
            FormMantProducto frm = new FormMantProducto();
            frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtprecio.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtstock.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.comboBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txtdescrip.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
            frm.ShowDialog();
            dgv();
        }
        public void dgvFiltro()
        {
            if (Filtro.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Selecione uma forma de filtro");

            }
            else
            {
                    ControladorProduto controladorProduto = new ControladorProduto();
                    DataSet dataSet = new DataSet();
                    string filtro = Filtro.SelectedItem.ToString();
                    string texto = materialSingleLineTextField1.Text;
                    dataSet = controladorProduto.retornaFiltro(filtro, texto);
                    dataGridView1.DataSource = dataSet;
                    dataGridView1.DataMember = dataSet.Tables[0].TableName;
            }
        }


     

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialSingleLineTextField1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgvFiltro();
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

     

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            FormMantProducto formMantProducto = new FormMantProducto();
            formMantProducto.ShowDialog();
        }
    }
}
