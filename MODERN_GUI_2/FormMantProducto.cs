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
    public partial class FormMantProducto : MaterialForm
    {
        public FormMantProducto()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void FormMantProducto_Load(object sender, EventArgs e)
        {
            popularComboBox();
            if(txtid.Text == "")
            {
                button1.Text = "Cadastrar";
            }
            else
            {
                button1.Text = "Atualizar";

            }
        }

        public void popularComboBox()
        {
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            DataTable dataTable = new DataTable();
            dataTable = controladorCategoria.preencheComboBox();
            comboBox2.DataSource = dataTable;
            comboBox2.ValueMember = "idCategoria";
            comboBox2.DisplayMember = "NomeCategoria";
            comboBox2.SelectedItem = "";
            comboBox2.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                if (txtNome.Text == "" || txtprecio.Text == "" || txtstock.Text == "" || txtdescrip.Text == "" || comboBox1.SelectedItem == null || comboBox2.SelectedValue == null)
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else
                {
                
                    ControladorProduto controladorProduto = new ControladorProduto();
                    controladorProduto.validarProduto(CriarProduto());
                    this.Close();
                }
            }
            else
            {
      
                ControladorProduto controladorProduto = new ControladorProduto();
                controladorProduto.Atualizar(CriarProduto());
                this.Close();
              
            }
        }
        private Produto CriarProduto()
        {
            Produto produto = new Produto();
            produto.nomeProduto = txtNome.Text;
            if (txtprecio.Text.Contains(","))
            {
                txtprecio.Text = txtprecio.Text.Replace(",", ".");
            }
            produto.ValorUnit = txtprecio.Text;
            if (txtstock.Text.Contains(","))
            {
                txtstock.Text = txtstock.Text.Replace(",", ".");
            }
            produto.Qtd = txtstock.Text;
            produto.idProduto = txtid.Text;
            produto.DescricaoProduto = txtdescrip.Text;
            produto.UnidadeMedida = comboBox1.SelectedItem.ToString();
            produto.TipoProduto = comboBox2.SelectedValue.ToString();
            return produto;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
