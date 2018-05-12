namespace QuadroMedalhas
{
    partial class FrmQuadro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdQuadro = new System.Windows.Forms.DataGridView();
            this.ttpNovo = new System.Windows.Forms.ToolTip(this.components);
            this.ttpRemover = new System.Windows.Forms.ToolTip(this.components);
            this.ttpEditar = new System.Windows.Forms.ToolTip(this.components);
            this.ttpDeslogar = new System.Windows.Forms.ToolTip(this.components);
            this.ttpLogar = new System.Windows.Forms.ToolTip(this.components);
            this.Bandeira = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_continente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuadro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeslogar);
            this.panel1.Controls.Add(this.btnLogar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 46);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisa:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(309, 6);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(182, 26);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdQuadro);
            this.panel2.Location = new System.Drawing.Point(13, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 311);
            this.panel2.TabIndex = 1;
            // 
            // grdQuadro
            // 
            this.grdQuadro.AllowUserToAddRows = false;
            this.grdQuadro.AllowUserToDeleteRows = false;
            this.grdQuadro.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdQuadro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdQuadro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQuadro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bandeira,
            this.ID,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.TOTAL,
            this.id_continente});
            this.grdQuadro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdQuadro.Location = new System.Drawing.Point(0, 0);
            this.grdQuadro.Name = "grdQuadro";
            this.grdQuadro.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdQuadro.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdQuadro.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdQuadro.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.grdQuadro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdQuadro.Size = new System.Drawing.Size(734, 311);
            this.grdQuadro.TabIndex = 0;
            // 
            // Bandeira
            // 
            this.Bandeira.DataPropertyName = "bandeira";
            this.Bandeira.DividerWidth = 2;
            this.Bandeira.HeaderText = "";
            this.Bandeira.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Bandeira.Name = "Bandeira";
            this.Bandeira.ReadOnly = true;
            this.Bandeira.Width = 40;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 45;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "sigla";
            this.Column1.HeaderText = "SIGLA";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "nome";
            this.Column2.HeaderText = "NOME";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 68;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "continente";
            this.Column3.HeaderText = "CONTINENTE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 112;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "ouro";
            this.Column4.HeaderText = "OURO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "prata";
            this.Column5.HeaderText = "PRATA";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "bronze";
            this.Column6.HeaderText = "BRONZE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TOTAL.DataPropertyName = "total";
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // id_continente
            // 
            this.id_continente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id_continente.DataPropertyName = "id_continente";
            this.id_continente.HeaderText = "id_continente";
            this.id_continente.Name = "id_continente";
            this.id_continente.ReadOnly = true;
            this.id_continente.Visible = false;
            this.id_continente.Width = 109;
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.BackgroundImage = global::QuadroMedalhas.Properties.Resources.botao_fechar;
            this.btnDeslogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeslogar.Location = new System.Drawing.Point(684, 3);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(47, 35);
            this.btnDeslogar.TabIndex = 4;
            this.ttpDeslogar.SetToolTip(this.btnDeslogar, "Sair da conta");
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.BackgroundImage = global::QuadroMedalhas.Properties.Resources.botao_login;
            this.btnLogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogar.Location = new System.Drawing.Point(684, 3);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(47, 35);
            this.btnLogar.TabIndex = 7;
            this.ttpLogar.SetToolTip(this.btnLogar, "Fazer login");
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::QuadroMedalhas.Properties.Resources.botao_alterar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(130, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 35);
            this.btnEditar.TabIndex = 2;
            this.ttpEditar.SetToolTip(this.btnEditar, "Editar país");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackgroundImage = global::QuadroMedalhas.Properties.Resources.botao_excluir;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemover.Location = new System.Drawing.Point(66, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(47, 35);
            this.btnRemover.TabIndex = 1;
            this.ttpRemover.SetToolTip(this.btnRemover, "Excluir país");
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::QuadroMedalhas.Properties.Resources.botao_inserir;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.Location = new System.Drawing.Point(3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(47, 35);
            this.btnNovo.TabIndex = 0;
            this.ttpNovo.SetToolTip(this.btnNovo, "Adicionar país");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // FrmQuadro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmQuadro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadro de Medalhas das Olimpíadas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQuadro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.DataGridView grdQuadro;
        private System.Windows.Forms.ToolTip ttpNovo;
        private System.Windows.Forms.ToolTip ttpRemover;
        private System.Windows.Forms.ToolTip ttpEditar;
        private System.Windows.Forms.ToolTip ttpDeslogar;
        private System.Windows.Forms.ToolTip ttpLogar;
        private System.Windows.Forms.DataGridViewImageColumn Bandeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_continente;
    }
}