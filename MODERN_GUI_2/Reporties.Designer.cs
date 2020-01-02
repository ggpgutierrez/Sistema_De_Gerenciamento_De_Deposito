namespace MODERN_GUI_2
{
    partial class Reporties
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvResposta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAno = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMes = new MaterialSkin.Controls.MaterialFlatButton();
            this.mes = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEspecifico = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtAno = new System.Windows.Forms.MaskedTextBox();
            this.especifica = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResposta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvResposta);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialFlatButton2.Location = new System.Drawing.Point(136, 414);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton2.TabIndex = 60;
            this.materialFlatButton2.Text = "Fechar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2_Click);
            // 
            // dgvResposta
            // 
            this.dgvResposta.AllowUserToDeleteRows = false;
            this.dgvResposta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.dgvResposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResposta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvResposta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResposta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResposta.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResposta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResposta.EnableHeadersVisualStyles = false;
            this.dgvResposta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.dgvResposta.Location = new System.Drawing.Point(111, 46);
            this.dgvResposta.Name = "dgvResposta";
            this.dgvResposta.ReadOnly = true;
            this.dgvResposta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResposta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResposta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvResposta.Size = new System.Drawing.Size(361, 332);
            this.dgvResposta.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.materialFlatButton2);
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Controls.Add(this.btnAno);
            this.panel1.Controls.Add(this.btnMes);
            this.panel1.Controls.Add(this.mes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEspecifico);
            this.panel1.Controls.Add(this.txtAno);
            this.panel1.Controls.Add(this.especifica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 4;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.Color.White;
            this.materialFlatButton1.Location = new System.Drawing.Point(33, 245);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(143, 36);
            this.materialFlatButton1.TabIndex = 13;
            this.materialFlatButton1.Text = "Buscar por venda";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // btnAno
            // 
            this.btnAno.AutoSize = true;
            this.btnAno.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAno.Depth = 0;
            this.btnAno.ForeColor = System.Drawing.Color.White;
            this.btnAno.Location = new System.Drawing.Point(72, 185);
            this.btnAno.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnAno.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAno.Name = "btnAno";
            this.btnAno.Primary = false;
            this.btnAno.Size = new System.Drawing.Size(65, 36);
            this.btnAno.TabIndex = 12;
            this.btnAno.Text = "Buscar";
            this.btnAno.UseVisualStyleBackColor = true;
            this.btnAno.Click += new System.EventHandler(this.BtnAno_Click);
            // 
            // btnMes
            // 
            this.btnMes.AutoSize = true;
            this.btnMes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMes.Depth = 0;
            this.btnMes.ForeColor = System.Drawing.Color.White;
            this.btnMes.Location = new System.Drawing.Point(75, 360);
            this.btnMes.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnMes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMes.Name = "btnMes";
            this.btnMes.Primary = false;
            this.btnMes.Size = new System.Drawing.Size(65, 36);
            this.btnMes.TabIndex = 11;
            this.btnMes.Text = "Buscar";
            this.btnMes.UseVisualStyleBackColor = true;
            this.btnMes.Click += new System.EventHandler(this.BtnMes_Click);
            // 
            // mes
            // 
            this.mes.Location = new System.Drawing.Point(55, 331);
            this.mes.Mask = "00/0000";
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(100, 20);
            this.mes.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(76, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mês e Ano";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data específica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ano";
            // 
            // btnEspecifico
            // 
            this.btnEspecifico.AutoSize = true;
            this.btnEspecifico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEspecifico.Depth = 0;
            this.btnEspecifico.ForeColor = System.Drawing.Color.White;
            this.btnEspecifico.Location = new System.Drawing.Point(75, 91);
            this.btnEspecifico.Margin = new System.Windows.Forms.Padding(10, 6, 4, 6);
            this.btnEspecifico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEspecifico.Name = "btnEspecifico";
            this.btnEspecifico.Primary = false;
            this.btnEspecifico.Size = new System.Drawing.Size(65, 36);
            this.btnEspecifico.TabIndex = 4;
            this.btnEspecifico.Text = "Buscar";
            this.btnEspecifico.UseVisualStyleBackColor = true;
            this.btnEspecifico.Click += new System.EventHandler(this.BtnEspecifico_Click);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(55, 157);
            this.txtAno.Mask = "0000";
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 1;
            // 
            // especifica
            // 
            this.especifica.Location = new System.Drawing.Point(55, 62);
            this.especifica.Mask = "00/00/0000";
            this.especifica.Name = "especifica";
            this.especifica.Size = new System.Drawing.Size(100, 20);
            this.especifica.TabIndex = 0;
            this.especifica.ValidatingType = typeof(System.DateTime);
            // 
            // Reporties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Reporties";
            this.Load += new System.EventHandler(this.Reporties_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResposta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox especifica;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnEspecifico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton btnMes;
        private System.Windows.Forms.MaskedTextBox mes;
        private MaterialSkin.Controls.MaterialFlatButton btnAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtAno;
        private System.Windows.Forms.DataGridView dgvResposta;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}