using MaterialSkin;
using MaterialSkin.Controls;
using MODERN_GUI_2.Controller;
using MODERN_GUI_2.Model;
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
    public partial class TelaCadCategoria : MaterialForm
    {
        public TelaCadCategoria()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Categorias categorias = new Categorias();
            categorias.Categoria = txtCategoria.Text;
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (controladorCategoria.validarCategoria(categorias))
                {
                    txtCategoria.Text = "";
                }
            }
        }

        private void TelaCadCategoria_Load(object sender, EventArgs e)
        {
            dgv();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizar();
        }
        public void atualizar()
        {
                TelatUpdateCategoria frm = new TelatUpdateCategoria();
                frm.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtCategoria.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.ShowDialog();
                dgv();

        }
        public void dgv()
        {
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet dataSet = new DataSet();
            dataSet = controladorCategoria.retorna();
            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = dataSet.Tables[0].TableName;
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            atualizar();

        }
    }
}
