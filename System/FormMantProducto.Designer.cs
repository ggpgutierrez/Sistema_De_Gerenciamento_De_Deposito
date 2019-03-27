namespace MODERN_GUI_2
{
    partial class FormMantProducto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtid = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdescrip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtprecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtstock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(431, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(57)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(294, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Metros",
            "Unitário"});
            this.comboBox1.Location = new System.Drawing.Point(247, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // txtid
            // 
            this.txtid.Depth = 0;
            this.txtid.Enabled = false;
            this.txtid.Hint = "ID";
            this.txtid.Location = new System.Drawing.Point(45, 76);
            this.txtid.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.Size = new System.Drawing.Size(44, 23);
            this.txtid.TabIndex = 31;
            this.txtid.UseSystemPasswordChar = false;
            // 
            // txtdescrip
            // 
            this.txtdescrip.Depth = 0;
            this.txtdescrip.Hint = "Descrição";
            this.txtdescrip.Location = new System.Drawing.Point(45, 134);
            this.txtdescrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.PasswordChar = '\0';
            this.txtdescrip.SelectedText = "";
            this.txtdescrip.SelectionLength = 0;
            this.txtdescrip.SelectionStart = 0;
            this.txtdescrip.Size = new System.Drawing.Size(323, 23);
            this.txtdescrip.TabIndex = 32;
            this.txtdescrip.UseSystemPasswordChar = false;
            // 
            // txtprecio
            // 
            this.txtprecio.Depth = 0;
            this.txtprecio.Hint = "Preço";
            this.txtprecio.Location = new System.Drawing.Point(45, 163);
            this.txtprecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.PasswordChar = '\0';
            this.txtprecio.SelectedText = "";
            this.txtprecio.SelectionLength = 0;
            this.txtprecio.SelectionStart = 0;
            this.txtprecio.Size = new System.Drawing.Size(185, 23);
            this.txtprecio.TabIndex = 33;
            this.txtprecio.UseSystemPasswordChar = false;
            // 
            // txtstock
            // 
            this.txtstock.Depth = 0;
            this.txtstock.Hint = "Quantidade";
            this.txtstock.Location = new System.Drawing.Point(45, 192);
            this.txtstock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtstock.Name = "txtstock";
            this.txtstock.PasswordChar = '\0';
            this.txtstock.SelectedText = "";
            this.txtstock.SelectionLength = 0;
            this.txtstock.SelectionStart = 0;
            this.txtstock.Size = new System.Drawing.Size(185, 23);
            this.txtstock.TabIndex = 34;
            this.txtstock.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome Produto";
            this.txtNome.Location = new System.Drawing.Point(45, 105);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(323, 23);
            this.txtNome.TabIndex = 35;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MODERN_GUI_2.Properties.Resources.if_file_roller_23794;
            this.pictureBox1.Location = new System.Drawing.Point(413, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(430, 211);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 36;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(450, 189);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 19);
            this.lblCategoria.TabIndex = 37;
            this.lblCategoria.Text = "Categoria";
            // 
            // FormMantProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 306);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtdescrip);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMantProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormMantProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtid;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtdescrip;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtprecio;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtstock;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        public System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        public System.Windows.Forms.ComboBox comboBox2;
    }
}