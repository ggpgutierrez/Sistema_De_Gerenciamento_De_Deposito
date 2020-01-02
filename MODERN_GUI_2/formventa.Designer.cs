namespace MODERN_GUI_2
{
    partial class formventa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFinalizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBusca = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnIncluir = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtQtd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRemover = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalCompra = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.desconto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Depth = 0;
            this.txtid.Hint = "ID do Produto";
            this.txtid.Location = new System.Drawing.Point(36, 93);
            this.txtid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.Size = new System.Drawing.Size(203, 23);
            this.txtid.TabIndex = 40;
            this.txtid.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(432, 216);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtFinalizar
            // 
            this.txtFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFinalizar.AutoSize = true;
            this.txtFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtFinalizar.Depth = 0;
            this.txtFinalizar.Location = new System.Drawing.Point(25, 324);
            this.txtFinalizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFinalizar.Name = "txtFinalizar";
            this.txtFinalizar.Primary = false;
            this.txtFinalizar.Size = new System.Drawing.Size(140, 36);
            this.txtFinalizar.TabIndex = 42;
            this.txtFinalizar.Text = "Finalizar Compra";
            this.txtFinalizar.UseVisualStyleBackColor = true;
            this.txtFinalizar.Click += new System.EventHandler(this.txtFinalizar_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.AutoSize = true;
            this.btnBusca.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBusca.Depth = 0;
            this.btnBusca.Location = new System.Drawing.Point(36, 154);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBusca.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Primary = false;
            this.btnBusca.Size = new System.Drawing.Size(65, 36);
            this.btnBusca.TabIndex = 43;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.AutoSize = true;
            this.btnIncluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIncluir.Depth = 0;
            this.btnIncluir.Location = new System.Drawing.Point(128, 154);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIncluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Primary = false;
            this.btnIncluir.Size = new System.Drawing.Size(63, 36);
            this.btnIncluir.TabIndex = 44;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(480, 319);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(44, 19);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Total";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(412, 310);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(411, 39);
            this.materialDivider1.TabIndex = 46;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtQtd
            // 
            this.txtQtd.Depth = 0;
            this.txtQtd.Hint = "Quantidade";
            this.txtQtd.Location = new System.Drawing.Point(36, 122);
            this.txtQtd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.PasswordChar = '\0';
            this.txtQtd.SelectedText = "";
            this.txtQtd.SelectionLength = 0;
            this.txtQtd.SelectionStart = 0;
            this.txtQtd.Size = new System.Drawing.Size(203, 23);
            this.txtQtd.TabIndex = 47;
            this.txtQtd.UseSystemPasswordChar = false;
            this.txtQtd.Click += new System.EventHandler(this.TxtQtd_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSize = true;
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.Depth = 0;
            this.btnRemover.Location = new System.Drawing.Point(25, 276);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Primary = false;
            this.btnRemover.Size = new System.Drawing.Size(133, 36);
            this.btnRemover.TabIndex = 48;
            this.btnRemover.Text = "Limpar Carrinho";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(747, 313);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 50;
            this.materialFlatButton1.Text = "Fechar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 70);
            this.panel1.TabIndex = 53;
            // 
            // totalCompra
            // 
            this.totalCompra.AutoSize = true;
            this.totalCompra.Depth = 0;
            this.totalCompra.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalCompra.Location = new System.Drawing.Point(544, 319);
            this.totalCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalCompra.Name = "totalCompra";
            this.totalCompra.Size = new System.Drawing.Size(0, 19);
            this.totalCompra.TabIndex = 54;
            this.totalCompra.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(180, 324);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(122, 36);
            this.materialFlatButton2.TabIndex = 55;
            this.materialFlatButton2.Text = "Gerar Cotação";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // desconto
            // 
            this.desconto.Depth = 0;
            this.desconto.Hint = "Desconto na venda";
            this.desconto.Location = new System.Drawing.Point(36, 216);
            this.desconto.MouseState = MaterialSkin.MouseState.HOVER;
            this.desconto.Name = "desconto";
            this.desconto.PasswordChar = '\0';
            this.desconto.SelectedText = "";
            this.desconto.SelectionLength = 0;
            this.desconto.SelectionStart = 0;
            this.desconto.Size = new System.Drawing.Size(203, 23);
            this.desconto.TabIndex = 56;
            this.desconto.UseSystemPasswordChar = false;
            // 
            // formventa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(835, 372);
            this.ControlBox = false;
            this.Controls.Add(this.desconto);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.totalCompra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtFinalizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.materialDivider1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formventa";
            this.ShowIcon = false;
            this.Sizable = false;
            this.Load += new System.EventHandler(this.formventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialFlatButton txtFinalizar;
        private MaterialSkin.Controls.MaterialFlatButton btnBusca;
        private MaterialSkin.Controls.MaterialFlatButton btnIncluir;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton btnRemover;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel totalCompra;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtQtd;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        public MaterialSkin.Controls.MaterialSingleLineTextField desconto;
    }
}