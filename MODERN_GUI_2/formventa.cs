using MaterialSkin;
using MaterialSkin.Controls;
using MODERN_GUI_2.Controller;
using MODERN_GUI_2.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODERN_GUI_2
{

    public partial class formventa : MaterialForm
    {
        List<Produto> produtos = new List<Produto>();
        List<double> totalProduto= new List<double>();


        public formventa()
        {

            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepOrange500, Primary.DeepOrange500,
                Primary.DeepOrange500, Accent.LightBlue200,
                TextShade.WHITE);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormProductos frm = new FormProductos();
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formventa_Load(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            FormProductos frm = new FormProductos();
            AddOwnedForm(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Controls.Add(frm);
            this.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto();
            produto.idProduto = txtid.Text;
            ControladorPedido controlador = new ControladorPedido();

            if (controlador.chamarItem(produto).idProduto == null)
            {

                MessageBox.Show("Produto não encontrado");
            }
     
               
                else
                {
                    if (txtQtd.Text == "")
                    {
                        MessageBox.Show("Por favor, inserir quantidade.");
                    }
                    else
                    {
                    if (Convert.ToDouble(controlador.chamarItem(produto).Qtd) < Convert.ToDouble(txtQtd.Text))
                    {
                        MessageBox.Show("Quantidade solicitada para o pedido é maior do que a que está em estoque");

                    }
                    else
                    {
                        Produto pro = new Produto();
                        pro = controlador.chamarItem(produto);
                        pro.Qtd = txtQtd.Text;
                        var aux = Convert.ToDouble(pro.Qtd) * Convert.ToDouble(pro.ValorUnit);
                        totalProduto.Add(aux);
                        produtos.Add(pro);


                        totalCompra.Text = Convert.ToString(totalProduto.Sum());
                        dataGridView1.DataSource = produtos;
                        dataGridView1.DataSource = null;

                        dataGridView1.DataSource = produtos;

                        dataGridView1.Columns[0].HeaderCell.Value = "Código";
                        dataGridView1.Columns[1].HeaderCell.Value = "Produto";
                        dataGridView1.Columns[2].HeaderCell.Value = "Valor";
                        dataGridView1.Columns[3].HeaderCell.Value = "Quantidade";
                        dataGridView1.Columns[4].HeaderCell.Value = "Unidade de Medida";

                        dataGridView1.Columns.Remove("DescricaoProduto");
                        dataGridView1.Columns.Remove("TipoProduto");

                    }
                    }
                }
            



        }

        private void btnRemover_Click(object sender, EventArgs e)
        {


            Produto produto = new Produto();
            produto.idProduto = txtid.Text;
            produtos.Clear();
            totalProduto.Clear();
            totalCompra.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = produtos;
            dataGridView1.Columns[0].HeaderCell.Value = "Código";
            dataGridView1.Columns[1].HeaderCell.Value = "Produto";
            dataGridView1.Columns[2].HeaderCell.Value = "Valor";
            dataGridView1.Columns[3].HeaderCell.Value = "Quantidade";
            dataGridView1.Columns[4].HeaderCell.Value = "Unidade de Medida";
            dataGridView1.Columns.Remove("DescricaoProduto");
            dataGridView1.Columns.Remove("TipoProduto");
        }



        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtFinalizar_Click(object sender, EventArgs e)
        {
            if (produtos.Count() >= 1)
            {

                double descont = Convert.ToDouble(desconto.Text.Replace(",", "."));
                ControladorPedido ped = new ControladorPedido();
                ped.finalizarPedido(produtos, totalProduto, descont);
            }
            else
            {
                MessageBox.Show("Nenhum produto no carrinho");
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            using (PrintDocument print = new PrintDocument())
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                print.PrintPage += Print_PrintPage;
                dialog.Document = print;
                dialog.ShowDialog();
            }

        }
        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
         

            using (Font font = new Font("Arial", 16))
            {
                Pen blackPen = new Pen(Color.Black, 3);

                // Create points that define line.
                PointF point1 = new PointF(100.0F, 100.0F);
                PointF point2 = new PointF(700.0F, 100.0F);
                string Date = DateTime.Now.ToString("dd/MM/yyyy");

                // Draw line to screen.
                g.DrawLine(blackPen, point1, point2);
                g.DrawString("Cotação do dia "+ Date, font, Brushes.Black, 100, 70);
                int linha = 130;
                g.DrawString("Nome do Produto", font, Brushes.Black, 105, 110);
                g.DrawString("Quantidade", font, Brushes.Black, 310, 110);
                g.DrawString("Unidade", font, Brushes.Black, 450, 110);
                g.DrawString("Total", font, Brushes.Black, 550, 110);
                double totalFinal = 0;

                produtos.ForEach(p =>
                {
                    double total = Convert.ToDouble(p.Qtd) * Convert.ToDouble(p.ValorUnit);
                    totalFinal += Convert.ToDouble(p.Qtd) * Convert.ToDouble(p.ValorUnit);
                    linha += 20;
                    g.DrawString(p.nomeProduto, font, Brushes.Black, 105, linha);
                    g.DrawString(p.Qtd, font, Brushes.Black, 310, linha);
                    g.DrawString(p.UnidadeMedida, font, Brushes.Black, 450, linha);
                    g.DrawString("R$" + total, font, Brushes.Black, 550, linha);
                });
                g.DrawString("Total da Cotação: R$" + totalFinal, font, Brushes.Black, 100, linha+=50);
                g.DrawString("___________________________________" , font, Brushes.Black, 100, linha += 120);
                g.DrawString("Assinatura do Vendedor", font, Brushes.Black, 190, linha += 30);




            }
        }

        private void TxtQtd_Click(object sender, EventArgs e)
        {

        }
    }
}

