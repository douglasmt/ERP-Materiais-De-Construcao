namespace Apresentacao
{
    partial class FrmMaterialCadastrar
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
            this.labelCodCad = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelUnid = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelQuant = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.textBoxQuant = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxUnid = new System.Windows.Forms.ComboBox();
            this.textBoxFornecedor = new System.Windows.Forms.TextBox();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelFase = new System.Windows.Forms.Label();
            this.textBoxFase = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.buttonBuscaFornecedor = new System.Windows.Forms.Button();
            this.textBoxFornecedorCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCodCad
            // 
            this.labelCodCad.AutoSize = true;
            this.labelCodCad.Location = new System.Drawing.Point(27, 11);
            this.labelCodCad.Name = "labelCodCad";
            this.labelCodCad.Size = new System.Drawing.Size(52, 17);
            this.labelCodCad.TabIndex = 0;
            this.labelCodCad.Text = "Código";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(27, 76);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(71, 17);
            this.labelDesc.TabIndex = 2;
            this.labelDesc.Text = "Descrição";
            // 
            // labelUnid
            // 
            this.labelUnid.AutoSize = true;
            this.labelUnid.Location = new System.Drawing.Point(27, 142);
            this.labelUnid.Name = "labelUnid";
            this.labelUnid.Size = new System.Drawing.Size(61, 17);
            this.labelUnid.TabIndex = 4;
            this.labelUnid.Text = "Unidade";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(27, 208);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(45, 17);
            this.labelPreco.TabIndex = 6;
            this.labelPreco.Text = "Preço";
            // 
            // labelQuant
            // 
            this.labelQuant.AutoSize = true;
            this.labelQuant.Location = new System.Drawing.Point(27, 273);
            this.labelQuant.Name = "labelQuant";
            this.labelQuant.Size = new System.Drawing.Size(82, 17);
            this.labelQuant.TabIndex = 8;
            this.labelQuant.Text = "Quantidade";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(27, 39);
            this.textBoxCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.ReadOnly = true;
            this.textBoxCod.Size = new System.Drawing.Size(71, 23);
            this.textBoxCod.TabIndex = 1;
            this.textBoxCod.TabStop = false;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxDesc.Location = new System.Drawing.Point(27, 105);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(243, 23);
            this.textBoxDesc.TabIndex = 3;
            this.textBoxDesc.Validated += new System.EventHandler(this.textBoxDesc_Validated);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSalvar.Location = new System.Drawing.Point(387, 341);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(99, 28);
            this.buttonSalvar.TabIndex = 16;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(496, 341);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(99, 28);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxValor.Location = new System.Drawing.Point(27, 236);
            this.textBoxValor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(132, 23);
            this.textBoxValor.TabIndex = 7;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxValor.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.textBoxValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValor_KeyPress);
            this.textBoxValor.Validated += new System.EventHandler(this.textBoxValor_Validated);
            // 
            // textBoxQuant
            // 
            this.textBoxQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxQuant.Location = new System.Drawing.Point(27, 302);
            this.textBoxQuant.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuant.Name = "textBoxQuant";
            this.textBoxQuant.Size = new System.Drawing.Size(132, 23);
            this.textBoxQuant.TabIndex = 9;
            this.textBoxQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxQuant.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.textBoxQuant.Validated += new System.EventHandler(this.textBoxQuant_Validated);
            // 
            // comboBoxUnid
            // 
            this.comboBoxUnid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBoxUnid.FormattingEnabled = true;
            this.comboBoxUnid.Items.AddRange(new object[] {
            "pc",
            "cm",
            "m",
            "m²",
            "m³",
            "ml",
            "l"});
            this.comboBoxUnid.Location = new System.Drawing.Point(27, 170);
            this.comboBoxUnid.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxUnid.Name = "comboBoxUnid";
            this.comboBoxUnid.Size = new System.Drawing.Size(132, 24);
            this.comboBoxUnid.TabIndex = 5;
            this.comboBoxUnid.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxFornecedor
            // 
            this.textBoxFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxFornecedor.Location = new System.Drawing.Point(434, 105);
            this.textBoxFornecedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFornecedor.Name = "textBoxFornecedor";
            this.textBoxFornecedor.Size = new System.Drawing.Size(161, 23);
            this.textBoxFornecedor.TabIndex = 11;
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Location = new System.Drawing.Point(387, 76);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(81, 17);
            this.labelFornecedor.TabIndex = 10;
            this.labelFornecedor.Text = "Fornecedor";
            // 
            // labelFase
            // 
            this.labelFase.AutoSize = true;
            this.labelFase.Location = new System.Drawing.Point(387, 142);
            this.labelFase.Name = "labelFase";
            this.labelFase.Size = new System.Drawing.Size(39, 17);
            this.labelFase.TabIndex = 12;
            this.labelFase.Text = "Fase";
            // 
            // textBoxFase
            // 
            this.textBoxFase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxFase.Location = new System.Drawing.Point(387, 170);
            this.textBoxFase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFase.Name = "textBoxFase";
            this.textBoxFase.Size = new System.Drawing.Size(39, 23);
            this.textBoxFase.TabIndex = 13;
            this.textBoxFase.TabStop = false;
            this.textBoxFase.TextChanged += new System.EventHandler(this.textBoxFase_TextChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(388, 208);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(38, 17);
            this.labelData.TabIndex = 14;
            this.labelData.Text = "Data";
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerData.Location = new System.Drawing.Point(391, 238);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(109, 23);
            this.dateTimePickerData.TabIndex = 15;
            // 
            // buttonBuscaFornecedor
            // 
            this.buttonBuscaFornecedor.Location = new System.Drawing.Point(602, 104);
            this.buttonBuscaFornecedor.Name = "buttonBuscaFornecedor";
            this.buttonBuscaFornecedor.Size = new System.Drawing.Size(31, 23);
            this.buttonBuscaFornecedor.TabIndex = 18;
            this.buttonBuscaFornecedor.Text = "...";
            this.buttonBuscaFornecedor.UseVisualStyleBackColor = true;
            this.buttonBuscaFornecedor.Click += new System.EventHandler(this.buttonBuscaFornecedor_Click);
            // 
            // textBoxFornecedorCod
            // 
            this.textBoxFornecedorCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxFornecedorCod.Location = new System.Drawing.Point(387, 106);
            this.textBoxFornecedorCod.Name = "textBoxFornecedorCod";
            this.textBoxFornecedorCod.Size = new System.Drawing.Size(39, 23);
            this.textBoxFornecedorCod.TabIndex = 19;
            // 
            // FrmMaterialCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 384);
            this.Controls.Add(this.textBoxFornecedorCod);
            this.Controls.Add(this.buttonBuscaFornecedor);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxFase);
            this.Controls.Add(this.labelFase);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.textBoxFornecedor);
            this.Controls.Add(this.comboBoxUnid);
            this.Controls.Add(this.textBoxQuant);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.labelQuant);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelUnid);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelCodCad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterialCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Material ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodCad;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelUnid;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelQuant;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.MaskedTextBox textBoxValor;
        private System.Windows.Forms.MaskedTextBox textBoxQuant;
        private System.Windows.Forms.ComboBox comboBoxUnid;
        private System.Windows.Forms.TextBox textBoxFornecedor;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelFase;
        private System.Windows.Forms.TextBox textBoxFase;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Button buttonBuscaFornecedor;
        private System.Windows.Forms.TextBox textBoxFornecedorCod;
    }
}