namespace Apresentacao
{
    partial class FrmTotais
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.radioButtonFase = new System.Windows.Forms.RadioButton();
            this.radioButtonFornecedor = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDigiteFase = new System.Windows.Forms.Label();
            this.textBoxFase = new System.Windows.Forms.TextBox();
            this.labelDigiteFornecedor = new System.Windows.Forms.Label();
            this.textBoxFornecedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTotal.Location = new System.Drawing.Point(12, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(221, 16);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Selecione a classificação de Total: ";
            // 
            // radioButtonFase
            // 
            this.radioButtonFase.AutoSize = true;
            this.radioButtonFase.Checked = true;
            this.radioButtonFase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioButtonFase.Location = new System.Drawing.Point(15, 28);
            this.radioButtonFase.Name = "radioButtonFase";
            this.radioButtonFase.Size = new System.Drawing.Size(76, 20);
            this.radioButtonFase.TabIndex = 1;
            this.radioButtonFase.TabStop = true;
            this.radioButtonFase.Text = "Por fase";
            this.radioButtonFase.UseVisualStyleBackColor = true;
            this.radioButtonFase.CheckedChanged += new System.EventHandler(this.radioButtonFase_CheckedChanged);
            // 
            // radioButtonFornecedor
            // 
            this.radioButtonFornecedor.AutoSize = true;
            this.radioButtonFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioButtonFornecedor.Location = new System.Drawing.Point(174, 28);
            this.radioButtonFornecedor.Name = "radioButtonFornecedor";
            this.radioButtonFornecedor.Size = new System.Drawing.Size(120, 20);
            this.radioButtonFornecedor.TabIndex = 2;
            this.radioButtonFornecedor.Text = "Por Fornecedor";
            this.radioButtonFornecedor.UseVisualStyleBackColor = true;
            this.radioButtonFornecedor.CheckedChanged += new System.EventHandler(this.radioButtonFornecedor_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCalcular.Location = new System.Drawing.Point(107, 123);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxTotal.Location = new System.Drawing.Point(55, 157);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(190, 22);
            this.textBoxTotal.TabIndex = 4;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelTotal.Location = new System.Drawing.Point(15, 160);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(42, 16);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // labelDigiteFase
            // 
            this.labelDigiteFase.AutoSize = true;
            this.labelDigiteFase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelDigiteFase.Location = new System.Drawing.Point(12, 69);
            this.labelDigiteFase.Name = "labelDigiteFase";
            this.labelDigiteFase.Size = new System.Drawing.Size(42, 16);
            this.labelDigiteFase.TabIndex = 6;
            this.labelDigiteFase.Text = "Fase:";
            // 
            // textBoxFase
            // 
            this.textBoxFase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxFase.Location = new System.Drawing.Point(15, 86);
            this.textBoxFase.Name = "textBoxFase";
            this.textBoxFase.Size = new System.Drawing.Size(100, 22);
            this.textBoxFase.TabIndex = 7;
            // 
            // labelDigiteFornecedor
            // 
            this.labelDigiteFornecedor.AutoSize = true;
            this.labelDigiteFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelDigiteFornecedor.Location = new System.Drawing.Point(171, 71);
            this.labelDigiteFornecedor.Name = "labelDigiteFornecedor";
            this.labelDigiteFornecedor.Size = new System.Drawing.Size(81, 16);
            this.labelDigiteFornecedor.TabIndex = 8;
            this.labelDigiteFornecedor.Text = "Fornecedor:";
            // 
            // textBoxFornecedor
            // 
            this.textBoxFornecedor.Location = new System.Drawing.Point(174, 87);
            this.textBoxFornecedor.Name = "textBoxFornecedor";
            this.textBoxFornecedor.Size = new System.Drawing.Size(100, 20);
            this.textBoxFornecedor.TabIndex = 9;
            // 
            // FrmTotais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 222);
            this.Controls.Add(this.textBoxFornecedor);
            this.Controls.Add(this.labelDigiteFornecedor);
            this.Controls.Add(this.textBoxFase);
            this.Controls.Add(this.labelDigiteFase);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.radioButtonFornecedor);
            this.Controls.Add(this.radioButtonFase);
            this.Controls.Add(this.lblTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTotais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totais";
            this.Load += new System.EventHandler(this.FrmTotais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton radioButtonFase;
        private System.Windows.Forms.RadioButton radioButtonFornecedor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDigiteFase;
        private System.Windows.Forms.TextBox textBoxFase;
        private System.Windows.Forms.Label labelDigiteFornecedor;
        private System.Windows.Forms.TextBox textBoxFornecedor;
    }
}