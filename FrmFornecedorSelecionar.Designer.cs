namespace Apresentacao
{
    partial class FrmFornecedorSelecionar
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
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.labelPesquisa = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewFornecedores = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ddd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ddd2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDDFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContDDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont2DDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont2Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont3DDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cont3Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocorr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltPed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodMunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.Location = new System.Drawing.Point(157, 12);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(623, 22);
            this.textBoxPesquisa.TabIndex = 0;
            // 
            // labelPesquisa
            // 
            this.labelPesquisa.AutoSize = true;
            this.labelPesquisa.Location = new System.Drawing.Point(13, 12);
            this.labelPesquisa.Name = "labelPesquisa";
            this.labelPesquisa.Size = new System.Drawing.Size(138, 16);
            this.labelPesquisa.TabIndex = 1;
            this.labelPesquisa.Text = "Código ou Descrição:";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(795, 9);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(100, 28);
            this.buttonPesquisar.TabIndex = 2;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // dataGridViewFornecedores
            // 
            this.dataGridViewFornecedores.AllowUserToAddRows = false;
            this.dataGridViewFornecedores.AllowUserToDeleteRows = false;
            this.dataGridViewFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Status,
            this.Situacao,
            this.Nome,
            this.Pessoa,
            this.CNPJ,
            this.Insc,
            this.End,
            this.Bai,
            this.Cid,
            this.Est,
            this.Cep,
            this.Ddd1,
            this.Fone1,
            this.Ddd2,
            this.Fone2,
            this.DDDFax,
            this.Fax,
            this.Cont,
            this.ContDDD,
            this.ContFone,
            this.Cont2,
            this.Cont2DDD,
            this.Cont2Fone,
            this.Cont3,
            this.Cont3DDD,
            this.Cont3Fone,
            this.Email,
            this.Fantasia,
            this.DataCad,
            this.Ocorr,
            this.UltPed,
            this.Tipo,
            this.Cnae,
            this.CodMunicipio});
            this.dataGridViewFornecedores.Location = new System.Drawing.Point(17, 56);
            this.dataGridViewFornecedores.MultiSelect = false;
            this.dataGridViewFornecedores.Name = "dataGridViewFornecedores";
            this.dataGridViewFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFornecedores.Size = new System.Drawing.Size(878, 329);
            this.dataGridViewFornecedores.TabIndex = 3;
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "Cod";
            this.Cod.HeaderText = "Código";
            this.Cod.Name = "Cod";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome do Fornecedor";
            this.Nome.MinimumWidth = 15;
            this.Nome.Name = "Nome";
            this.Nome.Width = 200;
            // 
            // Pessoa
            // 
            this.Pessoa.DataPropertyName = "Pessoa";
            this.Pessoa.HeaderText = "Tipo Pessoa";
            this.Pessoa.Name = "Pessoa";
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "Cnpj";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // Insc
            // 
            this.Insc.DataPropertyName = "Insc";
            this.Insc.HeaderText = "Inscrição";
            this.Insc.Name = "Insc";
            // 
            // End
            // 
            this.End.DataPropertyName = "End";
            this.End.HeaderText = "Endereço";
            this.End.Name = "End";
            // 
            // Bai
            // 
            this.Bai.DataPropertyName = "Bai";
            this.Bai.HeaderText = "Bairro";
            this.Bai.Name = "Bai";
            // 
            // Cid
            // 
            this.Cid.DataPropertyName = "Cid";
            this.Cid.HeaderText = "Cidade";
            this.Cid.Name = "Cid";
            // 
            // Est
            // 
            this.Est.DataPropertyName = "Est";
            this.Est.HeaderText = "Estado";
            this.Est.Name = "Est";
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "Cep";
            this.Cep.HeaderText = "CEP";
            this.Cep.Name = "Cep";
            // 
            // Ddd1
            // 
            this.Ddd1.DataPropertyName = "Ddd1";
            this.Ddd1.HeaderText = "DDD";
            this.Ddd1.Name = "Ddd1";
            this.Ddd1.Width = 50;
            // 
            // Fone1
            // 
            this.Fone1.DataPropertyName = "Fone1";
            this.Fone1.HeaderText = "Telefone 1";
            this.Fone1.Name = "Fone1";
            this.Fone1.Width = 80;
            // 
            // Ddd2
            // 
            this.Ddd2.DataPropertyName = "Ddd2";
            this.Ddd2.HeaderText = "DDD";
            this.Ddd2.Name = "Ddd2";
            this.Ddd2.Width = 50;
            // 
            // Fone2
            // 
            this.Fone2.DataPropertyName = "Fone2";
            this.Fone2.HeaderText = "Telefone 2";
            this.Fone2.Name = "Fone2";
            this.Fone2.Width = 80;
            // 
            // DDDFax
            // 
            this.DDDFax.DataPropertyName = "DDDFax";
            this.DDDFax.HeaderText = "DDD";
            this.DDDFax.Name = "DDDFax";
            this.DDDFax.Width = 50;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.Width = 80;
            // 
            // Cont
            // 
            this.Cont.DataPropertyName = "Cont";
            this.Cont.HeaderText = "Contato 1";
            this.Cont.Name = "Cont";
            // 
            // ContDDD
            // 
            this.ContDDD.DataPropertyName = "ContDDD";
            this.ContDDD.HeaderText = "DDD";
            this.ContDDD.Name = "ContDDD";
            this.ContDDD.Width = 50;
            // 
            // ContFone
            // 
            this.ContFone.DataPropertyName = "ContFone";
            this.ContFone.HeaderText = "Fone";
            this.ContFone.Name = "ContFone";
            this.ContFone.Width = 80;
            // 
            // Cont2
            // 
            this.Cont2.DataPropertyName = "Cont2";
            this.Cont2.HeaderText = "Contato 2";
            this.Cont2.Name = "Cont2";
            // 
            // Cont2DDD
            // 
            this.Cont2DDD.DataPropertyName = "Cont2DDD";
            this.Cont2DDD.HeaderText = "DDD";
            this.Cont2DDD.Name = "Cont2DDD";
            this.Cont2DDD.Width = 50;
            // 
            // Cont2Fone
            // 
            this.Cont2Fone.DataPropertyName = "Cont2Fone";
            this.Cont2Fone.HeaderText = "Fone";
            this.Cont2Fone.Name = "Cont2Fone";
            this.Cont2Fone.Width = 80;
            // 
            // Cont3
            // 
            this.Cont3.DataPropertyName = "Cont3";
            this.Cont3.HeaderText = "Contato 3";
            this.Cont3.Name = "Cont3";
            // 
            // Cont3DDD
            // 
            this.Cont3DDD.DataPropertyName = "Cont3DDD";
            this.Cont3DDD.HeaderText = "DDD";
            this.Cont3DDD.Name = "Cont3DDD";
            this.Cont3DDD.Width = 50;
            // 
            // Cont3Fone
            // 
            this.Cont3Fone.DataPropertyName = "Cont3Fone";
            this.Cont3Fone.HeaderText = "Fone";
            this.Cont3Fone.Name = "Cont3Fone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            // 
            // Fantasia
            // 
            this.Fantasia.DataPropertyName = "Fantasia";
            this.Fantasia.HeaderText = "Nome Fantasia";
            this.Fantasia.Name = "Fantasia";
            this.Fantasia.Width = 120;
            // 
            // DataCad
            // 
            this.DataCad.DataPropertyName = "DataCad";
            this.DataCad.HeaderText = "Cadastro";
            this.DataCad.Name = "DataCad";
            // 
            // Ocorr
            // 
            this.Ocorr.DataPropertyName = "Ocorr";
            this.Ocorr.HeaderText = "Ocorrência";
            this.Ocorr.Name = "Ocorr";
            // 
            // UltPed
            // 
            this.UltPed.DataPropertyName = "UltPed";
            this.UltPed.HeaderText = "Último Pedido";
            this.UltPed.Name = "UltPed";
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Cnae
            // 
            this.Cnae.DataPropertyName = "Cnae";
            this.Cnae.HeaderText = "CNAE";
            this.Cnae.Name = "Cnae";
            // 
            // CodMunicipio
            // 
            this.CodMunicipio.DataPropertyName = "CodMunicipio";
            this.CodMunicipio.HeaderText = "Código de Município";
            this.CodMunicipio.Name = "CodMunicipio";
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(795, 406);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(100, 28);
            this.buttonFechar.TabIndex = 4;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Location = new System.Drawing.Point(17, 410);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(100, 28);
            this.buttonSelecionar.TabIndex = 5;
            this.buttonSelecionar.Text = "Escolher";
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // FrmFornecedorSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 446);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.dataGridViewFornecedores);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.labelPesquisa);
            this.Controls.Add(this.textBoxPesquisa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFornecedorSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha o Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Label labelPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewFornecedores;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insc;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ddd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ddd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDDFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContDDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont2DDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont2Fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont3DDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cont3Fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocorr;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnae;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMunicipio;
        private System.Windows.Forms.Button buttonSelecionar;
    }
}