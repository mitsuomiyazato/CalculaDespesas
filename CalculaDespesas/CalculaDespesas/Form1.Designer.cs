namespace CalculaDespesas
{
	partial class Despesas
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
			this.grpBoxItem = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.rdbBtnType2 = new System.Windows.Forms.RadioButton();
			this.lblType = new System.Windows.Forms.Label();
			this.rdbBtnType1 = new System.Windows.Forms.RadioButton();
			this.mskTxtValue = new System.Windows.Forms.MaskedTextBox();
			this.lblValue = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.titleDespesas = new System.Windows.Forms.Label();
			this.lblLstLucro = new System.Windows.Forms.Label();
			this.lblListDespesa = new System.Windows.Forms.Label();
			this.lblSaldo = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnCopiar = new System.Windows.Forms.Button();
			this.TxtSaldo = new System.Windows.Forms.TextBox();
			this.gridLucro = new System.Windows.Forms.DataGridView();
			this.gridDespesa = new System.Windows.Forms.DataGridView();
			this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grpBoxItem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLucro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDespesa)).BeginInit();
			this.SuspendLayout();
			// 
			// grpBoxItem
			// 
			this.grpBoxItem.Controls.Add(this.button1);
			this.grpBoxItem.Controls.Add(this.rdbBtnType2);
			this.grpBoxItem.Controls.Add(this.lblType);
			this.grpBoxItem.Controls.Add(this.rdbBtnType1);
			this.grpBoxItem.Controls.Add(this.mskTxtValue);
			this.grpBoxItem.Controls.Add(this.lblValue);
			this.grpBoxItem.Controls.Add(this.txtName);
			this.grpBoxItem.Controls.Add(this.lblName);
			this.grpBoxItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.grpBoxItem.Location = new System.Drawing.Point(13, 68);
			this.grpBoxItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.grpBoxItem.Name = "grpBoxItem";
			this.grpBoxItem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.grpBoxItem.Size = new System.Drawing.Size(347, 185);
			this.grpBoxItem.TabIndex = 0;
			this.grpBoxItem.TabStop = false;
			this.grpBoxItem.Text = "Item";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Desktop;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Swis721 Hv BT", 12F);
			this.button1.Location = new System.Drawing.Point(5, 134);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(335, 45);
			this.button1.TabIndex = 9;
			this.button1.Text = "Adicionar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// rdbBtnType2
			// 
			this.rdbBtnType2.AutoSize = true;
			this.rdbBtnType2.Font = new System.Drawing.Font("Swis721 Hv BT", 12F);
			this.rdbBtnType2.Location = new System.Drawing.Point(219, 103);
			this.rdbBtnType2.Name = "rdbBtnType2";
			this.rdbBtnType2.Size = new System.Drawing.Size(96, 23);
			this.rdbBtnType2.TabIndex = 7;
			this.rdbBtnType2.Text = "Despesa";
			this.rdbBtnType2.UseVisualStyleBackColor = true;
			// 
			// lblType
			// 
			this.lblType.AutoSize = true;
			this.lblType.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblType.Location = new System.Drawing.Point(7, 103);
			this.lblType.Name = "lblType";
			this.lblType.Size = new System.Drawing.Size(49, 19);
			this.lblType.TabIndex = 6;
			this.lblType.Text = "Tipo:";
			// 
			// rdbBtnType1
			// 
			this.rdbBtnType1.AutoSize = true;
			this.rdbBtnType1.Checked = true;
			this.rdbBtnType1.Font = new System.Drawing.Font("Swis721 Hv BT", 12F);
			this.rdbBtnType1.Location = new System.Drawing.Point(92, 103);
			this.rdbBtnType1.Name = "rdbBtnType1";
			this.rdbBtnType1.Size = new System.Drawing.Size(73, 23);
			this.rdbBtnType1.TabIndex = 5;
			this.rdbBtnType1.TabStop = true;
			this.rdbBtnType1.Text = "Lucro";
			this.rdbBtnType1.UseVisualStyleBackColor = true;
			// 
			// mskTxtValue
			// 
			this.mskTxtValue.Font = new System.Drawing.Font("Swis721 Hv BT", 12F);
			this.mskTxtValue.Location = new System.Drawing.Point(92, 66);
			this.mskTxtValue.Mask = "00000.00";
			this.mskTxtValue.Name = "mskTxtValue";
			this.mskTxtValue.Size = new System.Drawing.Size(248, 27);
			this.mskTxtValue.TabIndex = 4;
			// 
			// lblValue
			// 
			this.lblValue.AutoSize = true;
			this.lblValue.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblValue.Location = new System.Drawing.Point(7, 69);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(81, 19);
			this.lblValue.TabIndex = 2;
			this.lblValue.Text = "Valor: R$";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Swis721 Hv BT", 12F);
			this.txtName.Location = new System.Drawing.Point(74, 33);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(266, 27);
			this.txtName.TabIndex = 1;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Swis721 Hv BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(7, 36);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(61, 19);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Nome:";
			// 
			// titleDespesas
			// 
			this.titleDespesas.AutoSize = true;
			this.titleDespesas.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleDespesas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.titleDespesas.Location = new System.Drawing.Point(275, 9);
			this.titleDespesas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.titleDespesas.Name = "titleDespesas";
			this.titleDespesas.Size = new System.Drawing.Size(204, 45);
			this.titleDespesas.TabIndex = 1;
			this.titleDespesas.Text = "Despesas";
			// 
			// lblLstLucro
			// 
			this.lblLstLucro.AutoSize = true;
			this.lblLstLucro.Font = new System.Drawing.Font("Swis721 Hv BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLstLucro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblLstLucro.Location = new System.Drawing.Point(12, 265);
			this.lblLstLucro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLstLucro.Name = "lblLstLucro";
			this.lblLstLucro.Size = new System.Drawing.Size(117, 32);
			this.lblLstLucro.TabIndex = 2;
			this.lblLstLucro.Text = "Lucros:";
			// 
			// lblListDespesa
			// 
			this.lblListDespesa.AutoSize = true;
			this.lblListDespesa.Font = new System.Drawing.Font("Swis721 Hv BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblListDespesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblListDespesa.Location = new System.Drawing.Point(384, 265);
			this.lblListDespesa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblListDespesa.Name = "lblListDespesa";
			this.lblListDespesa.Size = new System.Drawing.Size(156, 32);
			this.lblListDespesa.TabIndex = 4;
			this.lblListDespesa.Text = "Despesas:";
			// 
			// lblSaldo
			// 
			this.lblSaldo.AutoSize = true;
			this.lblSaldo.Font = new System.Drawing.Font("Swis721 Hv BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblSaldo.Location = new System.Drawing.Point(384, 137);
			this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSaldo.Name = "lblSaldo";
			this.lblSaldo.Size = new System.Drawing.Size(99, 32);
			this.lblSaldo.TabIndex = 6;
			this.lblSaldo.Text = "Saldo:";
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpar.Font = new System.Drawing.Font("Swis721 Hv BT", 12F);
			this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLimpar.Location = new System.Drawing.Point(384, 459);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(346, 45);
			this.btnLimpar.TabIndex = 10;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Font = new System.Drawing.Font("Swis721 Hv BT", 12F);
			this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnExcluir.Location = new System.Drawing.Point(13, 459);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(347, 45);
			this.btnExcluir.TabIndex = 11;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnCopiar
			// 
			this.btnCopiar.BackColor = System.Drawing.SystemColors.Desktop;
			this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCopiar.Font = new System.Drawing.Font("Swis721 Hv BT", 12F);
			this.btnCopiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCopiar.Location = new System.Drawing.Point(12, 521);
			this.btnCopiar.Name = "btnCopiar";
			this.btnCopiar.Size = new System.Drawing.Size(718, 45);
			this.btnCopiar.TabIndex = 12;
			this.btnCopiar.Text = "Copiar Tudo";
			this.btnCopiar.UseVisualStyleBackColor = false;
			this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
			// 
			// TxtSaldo
			// 
			this.TxtSaldo.Font = new System.Drawing.Font("Swis721 Hv BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSaldo.Location = new System.Drawing.Point(490, 134);
			this.TxtSaldo.Name = "TxtSaldo";
			this.TxtSaldo.Size = new System.Drawing.Size(215, 40);
			this.TxtSaldo.TabIndex = 13;
			this.TxtSaldo.Text = "R$ 0,00";
			// 
			// gridLucro
			// 
			this.gridLucro.AllowUserToAddRows = false;
			this.gridLucro.AllowUserToDeleteRows = false;
			this.gridLucro.AllowUserToResizeColumns = false;
			this.gridLucro.AllowUserToResizeRows = false;
			this.gridLucro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridLucro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridLucro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cValue});
			this.gridLucro.Location = new System.Drawing.Point(12, 300);
			this.gridLucro.Name = "gridLucro";
			this.gridLucro.RowHeadersVisible = false;
			this.gridLucro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridLucro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridLucro.Size = new System.Drawing.Size(348, 144);
			this.gridLucro.TabIndex = 14;
			// 
			// gridDespesa
			// 
			this.gridDespesa.AllowUserToAddRows = false;
			this.gridDespesa.AllowUserToDeleteRows = false;
			this.gridDespesa.AllowUserToResizeColumns = false;
			this.gridDespesa.AllowUserToResizeRows = false;
			this.gridDespesa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gridDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNome,
            this.cValor});
			this.gridDespesa.Location = new System.Drawing.Point(384, 300);
			this.gridDespesa.Name = "gridDespesa";
			this.gridDespesa.RowHeadersVisible = false;
			this.gridDespesa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridDespesa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridDespesa.Size = new System.Drawing.Size(348, 144);
			this.gridDespesa.TabIndex = 15;
			// 
			// cName
			// 
			this.cName.HeaderText = "Nome";
			this.cName.Name = "cName";
			// 
			// cValue
			// 
			this.cValue.HeaderText = "Valor";
			this.cValue.Name = "cValue";
			// 
			// cNome
			// 
			this.cNome.HeaderText = "Nome";
			this.cNome.Name = "cNome";
			// 
			// cValor
			// 
			this.cValor.HeaderText = "Valor";
			this.cValor.Name = "cValor";
			// 
			// Despesas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Desktop;
			this.ClientSize = new System.Drawing.Size(742, 578);
			this.Controls.Add(this.gridDespesa);
			this.Controls.Add(this.gridLucro);
			this.Controls.Add(this.TxtSaldo);
			this.Controls.Add(this.btnCopiar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.lblSaldo);
			this.Controls.Add(this.lblListDespesa);
			this.Controls.Add(this.lblLstLucro);
			this.Controls.Add(this.titleDespesas);
			this.Controls.Add(this.grpBoxItem);
			this.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "Despesas";
			this.Text = "Despesas";
			this.grpBoxItem.ResumeLayout(false);
			this.grpBoxItem.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLucro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDespesa)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpBoxItem;
		private System.Windows.Forms.Label titleDespesas;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.MaskedTextBox mskTxtValue;
		private System.Windows.Forms.RadioButton rdbBtnType2;
		private System.Windows.Forms.Label lblType;
		private System.Windows.Forms.RadioButton rdbBtnType1;
		private System.Windows.Forms.Label lblLstLucro;
		private System.Windows.Forms.Label lblListDespesa;
		private System.Windows.Forms.Label lblSaldo;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnCopiar;
		private System.Windows.Forms.TextBox TxtSaldo;
		private System.Windows.Forms.DataGridView gridLucro;
		private System.Windows.Forms.DataGridViewTextBoxColumn cName;
		private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
		private System.Windows.Forms.DataGridView gridDespesa;
		private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn cValor;
	}
}

