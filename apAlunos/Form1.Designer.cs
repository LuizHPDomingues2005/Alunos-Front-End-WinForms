namespace apAlunos
{
    partial class FrmAlunos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpAcoes = new System.Windows.Forms.GroupBox();
            this.rbDelete = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.rbGetOne = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.rbGetAll = new System.Windows.Forms.RadioButton();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.lbRa = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lbNumResi = new System.Windows.Forms.Label();
            this.txtNumResi = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.gpAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowDrop = true;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(13, 196);
            this.dgvAlunos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(1045, 280);
            this.dgvAlunos.TabIndex = 0;
            this.dgvAlunos.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(940, 20);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 40);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gpAcoes
            // 
            this.gpAcoes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpAcoes.Controls.Add(this.rbDelete);
            this.gpAcoes.Controls.Add(this.rbUpdate);
            this.gpAcoes.Controls.Add(this.rbGetOne);
            this.gpAcoes.Controls.Add(this.rbInsert);
            this.gpAcoes.Controls.Add(this.rbGetAll);
            this.gpAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAcoes.Location = new System.Drawing.Point(13, 12);
            this.gpAcoes.Name = "gpAcoes";
            this.gpAcoes.Size = new System.Drawing.Size(274, 176);
            this.gpAcoes.TabIndex = 2;
            this.gpAcoes.TabStop = false;
            this.gpAcoes.Text = "Ações";
            // 
            // rbDelete
            // 
            this.rbDelete.AutoSize = true;
            this.rbDelete.Location = new System.Drawing.Point(17, 147);
            this.rbDelete.Name = "rbDelete";
            this.rbDelete.Size = new System.Drawing.Size(134, 21);
            this.rbDelete.TabIndex = 6;
            this.rbDelete.Text = "Deletar um aluno";
            this.rbDelete.UseVisualStyleBackColor = true;
            this.rbDelete.CheckedChanged += new System.EventHandler(this.rbDelete_CheckedChanged);
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(17, 117);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(244, 21);
            this.rbUpdate.TabIndex = 7;
            this.rbUpdate.Text = "Atualizar informações de um aluno";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // rbGetOne
            // 
            this.rbGetOne.AutoSize = true;
            this.rbGetOne.Location = new System.Drawing.Point(17, 57);
            this.rbGetOne.Name = "rbGetOne";
            this.rbGetOne.Size = new System.Drawing.Size(123, 21);
            this.rbGetOne.TabIndex = 4;
            this.rbGetOne.Text = "Listar um aluno";
            this.rbGetOne.UseVisualStyleBackColor = true;
            this.rbGetOne.CheckedChanged += new System.EventHandler(this.rbGetOne_CheckedChanged);
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Location = new System.Drawing.Point(17, 87);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(127, 21);
            this.rbInsert.TabIndex = 5;
            this.rbInsert.Text = "Inserir um aluno";
            this.rbInsert.UseVisualStyleBackColor = true;
            this.rbInsert.CheckedChanged += new System.EventHandler(this.rbInsert_CheckedChanged);
            // 
            // rbGetAll
            // 
            this.rbGetAll.AutoSize = true;
            this.rbGetAll.Location = new System.Drawing.Point(17, 27);
            this.rbGetAll.Name = "rbGetAll";
            this.rbGetAll.Size = new System.Drawing.Size(105, 21);
            this.rbGetAll.TabIndex = 3;
            this.rbGetAll.Text = "Listar Todos";
            this.rbGetAll.UseVisualStyleBackColor = true;
            this.rbGetAll.CheckedChanged += new System.EventHandler(this.rbGetAll_CheckedChanged);
            // 
            // txtRa
            // 
            this.txtRa.Location = new System.Drawing.Point(356, 12);
            this.txtRa.MaxLength = 5;
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(87, 26);
            this.txtRa.TabIndex = 3;
            this.txtRa.Visible = false;
            this.txtRa.TextChanged += new System.EventHandler(this.txtRa_TextChanged);
            // 
            // lbRa
            // 
            this.lbRa.AutoSize = true;
            this.lbRa.Location = new System.Drawing.Point(302, 15);
            this.lbRa.Name = "lbRa";
            this.lbRa.Size = new System.Drawing.Size(36, 20);
            this.lbRa.TabIndex = 4;
            this.lbRa.Text = "RA:";
            this.lbRa.Visible = false;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(302, 47);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 6;
            this.lbNome.Text = "Nome:";
            this.lbNome.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(356, 44);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 26);
            this.txtNome.TabIndex = 5;
            this.txtNome.Visible = false;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(302, 79);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(45, 20);
            this.lbCep.TabIndex = 8;
            this.lbCep.Text = "CEP:";
            this.lbCep.Visible = false;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(356, 76);
            this.txtCep.MaxLength = 8;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(183, 26);
            this.txtCep.TabIndex = 7;
            this.txtCep.Visible = false;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(302, 114);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(112, 20);
            this.lbComplemento.TabIndex = 10;
            this.lbComplemento.Text = "Complemento:";
            this.lbComplemento.Visible = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(420, 108);
            this.txtComplemento.MaxLength = 20;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(119, 26);
            this.txtComplemento.TabIndex = 9;
            this.txtComplemento.Visible = false;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // lbNumResi
            // 
            this.lbNumResi.AutoSize = true;
            this.lbNumResi.Location = new System.Drawing.Point(302, 143);
            this.lbNumResi.Name = "lbNumResi";
            this.lbNumResi.Size = new System.Drawing.Size(167, 20);
            this.lbNumResi.TabIndex = 12;
            this.lbNumResi.Text = "Número de residência:";
            this.lbNumResi.Visible = false;
            // 
            // txtNumResi
            // 
            this.txtNumResi.Location = new System.Drawing.Point(475, 140);
            this.txtNumResi.MaxLength = 10;
            this.txtNumResi.Name = "txtNumResi";
            this.txtNumResi.Size = new System.Drawing.Size(89, 26);
            this.txtNumResi.TabIndex = 11;
            this.txtNumResi.Visible = false;
            this.txtNumResi.TextChanged += new System.EventHandler(this.txtNumResi_TextChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(940, 70);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(108, 50);
            this.btnInserir.TabIndex = 13;
            this.btnInserir.Text = "Inserir dados";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Visible = false;
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 490);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.lbNumResi);
            this.Controls.Add(this.txtNumResi);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lbCep);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbRa);
            this.Controls.Add(this.txtRa);
            this.Controls.Add(this.gpAcoes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvAlunos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAlunos";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.gpAcoes.ResumeLayout(false);
            this.gpAcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpAcoes;
        private System.Windows.Forms.RadioButton rbDelete;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.RadioButton rbGetOne;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.RadioButton rbGetAll;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.Label lbRa;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lbNumResi;
        private System.Windows.Forms.TextBox txtNumResi;
        private System.Windows.Forms.Button btnInserir;
    }
}

