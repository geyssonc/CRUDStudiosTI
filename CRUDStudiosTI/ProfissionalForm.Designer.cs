
namespace CRUDStudiosTI
{
	partial class ProfissionalForm
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
			this.ProfissionalDataGridView = new System.Windows.Forms.DataGridView();
			this.NomeCompletoTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TelefoneTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.RGTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.EnderecoTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SalarioTextBox = new System.Windows.Forms.TextBox();
			this.GravarButton = new System.Windows.Forms.Button();
			this.ExcluirButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.IdEdicaoTextBox = new System.Windows.Forms.TextBox();
			this.EditarColumn = new System.Windows.Forms.DataGridViewButtonColumn();
			this.HoraExtraButton = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.profissionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ProfissionalDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profissionalBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ProfissionalDataGridView
			// 
			this.ProfissionalDataGridView.AllowUserToAddRows = false;
			this.ProfissionalDataGridView.AllowUserToDeleteRows = false;
			this.ProfissionalDataGridView.AutoGenerateColumns = false;
			this.ProfissionalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProfissionalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn,
            this.EditarColumn});
			this.ProfissionalDataGridView.DataSource = this.profissionalBindingSource;
			this.ProfissionalDataGridView.Location = new System.Drawing.Point(29, 185);
			this.ProfissionalDataGridView.Name = "ProfissionalDataGridView";
			this.ProfissionalDataGridView.ReadOnly = true;
			this.ProfissionalDataGridView.Size = new System.Drawing.Size(860, 204);
			this.ProfissionalDataGridView.TabIndex = 0;
			this.ProfissionalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProfissionalDataGridView_CellContentClick);
			// 
			// NomeCompletoTextBox
			// 
			this.NomeCompletoTextBox.Location = new System.Drawing.Point(29, 42);
			this.NomeCompletoTextBox.Name = "NomeCompletoTextBox";
			this.NomeCompletoTextBox.Size = new System.Drawing.Size(371, 20);
			this.NomeCompletoTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nome Completo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(406, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Telefone";
			// 
			// TelefoneTextBox
			// 
			this.TelefoneTextBox.Location = new System.Drawing.Point(406, 42);
			this.TelefoneTextBox.Name = "TelefoneTextBox";
			this.TelefoneTextBox.Size = new System.Drawing.Size(255, 20);
			this.TelefoneTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(667, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "RG";
			// 
			// RGTextBox
			// 
			this.RGTextBox.Location = new System.Drawing.Point(667, 42);
			this.RGTextBox.Name = "RGTextBox";
			this.RGTextBox.Size = new System.Drawing.Size(222, 20);
			this.RGTextBox.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Endereço";
			// 
			// EnderecoTextBox
			// 
			this.EnderecoTextBox.Location = new System.Drawing.Point(29, 96);
			this.EnderecoTextBox.Name = "EnderecoTextBox";
			this.EnderecoTextBox.Size = new System.Drawing.Size(632, 20);
			this.EnderecoTextBox.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(670, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Salário";
			// 
			// SalarioTextBox
			// 
			this.SalarioTextBox.Location = new System.Drawing.Point(670, 96);
			this.SalarioTextBox.Name = "SalarioTextBox";
			this.SalarioTextBox.Size = new System.Drawing.Size(219, 20);
			this.SalarioTextBox.TabIndex = 9;
			// 
			// GravarButton
			// 
			this.GravarButton.Location = new System.Drawing.Point(733, 136);
			this.GravarButton.Name = "GravarButton";
			this.GravarButton.Size = new System.Drawing.Size(75, 23);
			this.GravarButton.TabIndex = 11;
			this.GravarButton.Text = "Gravar";
			this.GravarButton.UseVisualStyleBackColor = true;
			this.GravarButton.Click += new System.EventHandler(this.GravarButton_Click);
			// 
			// ExcluirButton
			// 
			this.ExcluirButton.Enabled = false;
			this.ExcluirButton.Location = new System.Drawing.Point(814, 137);
			this.ExcluirButton.Name = "ExcluirButton";
			this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
			this.ExcluirButton.TabIndex = 12;
			this.ExcluirButton.Text = "Excluir";
			this.ExcluirButton.UseVisualStyleBackColor = true;
			this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 142);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Id Edição";
			// 
			// IdEdicaoTextBox
			// 
			this.IdEdicaoTextBox.Enabled = false;
			this.IdEdicaoTextBox.Location = new System.Drawing.Point(87, 139);
			this.IdEdicaoTextBox.Name = "IdEdicaoTextBox";
			this.IdEdicaoTextBox.Size = new System.Drawing.Size(100, 20);
			this.IdEdicaoTextBox.TabIndex = 14;
			// 
			// EditarColumn
			// 
			this.EditarColumn.HeaderText = "Editar";
			this.EditarColumn.Name = "EditarColumn";
			this.EditarColumn.ReadOnly = true;
			this.EditarColumn.Text = "Editar";
			this.EditarColumn.UseColumnTextForButtonValue = true;
			// 
			// HoraExtraButton
			// 
			this.HoraExtraButton.Location = new System.Drawing.Point(814, 409);
			this.HoraExtraButton.Name = "HoraExtraButton";
			this.HoraExtraButton.Size = new System.Drawing.Size(75, 23);
			this.HoraExtraButton.TabIndex = 15;
			this.HoraExtraButton.Text = "Hora Extra";
			this.HoraExtraButton.UseVisualStyleBackColor = true;
			this.HoraExtraButton.Click += new System.EventHandler(this.HoraExtraButton_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeCompletoDataGridViewTextBoxColumn
			// 
			this.nomeCompletoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
			this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "NomeCompleto";
			this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
			this.nomeCompletoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// telefoneDataGridViewTextBoxColumn
			// 
			this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
			this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
			this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
			this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rGDataGridViewTextBoxColumn
			// 
			this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
			this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
			this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
			this.rGDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// enderecoDataGridViewTextBoxColumn
			// 
			this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
			this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
			this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
			this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// salarioDataGridViewTextBoxColumn
			// 
			this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
			this.salarioDataGridViewTextBoxColumn.HeaderText = "Salario";
			this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
			this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// profissionalBindingSource
			// 
			this.profissionalBindingSource.DataSource = typeof(CRUDStudiosTI.Profissional);
			// 
			// ProfissionalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(916, 457);
			this.Controls.Add(this.HoraExtraButton);
			this.Controls.Add(this.IdEdicaoTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ExcluirButton);
			this.Controls.Add(this.GravarButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.SalarioTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.EnderecoTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.RGTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TelefoneTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NomeCompletoTextBox);
			this.Controls.Add(this.ProfissionalDataGridView);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProfissionalForm";
			this.ShowIcon = false;
			this.Text = "CRUD Profissional";
			this.Load += new System.EventHandler(this.ProfissionalForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ProfissionalDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profissionalBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView ProfissionalDataGridView;
		private System.Windows.Forms.TextBox NomeCompletoTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TelefoneTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox RGTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox EnderecoTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox SalarioTextBox;
		private System.Windows.Forms.Button GravarButton;
		private System.Windows.Forms.Button ExcluirButton;
		private System.Windows.Forms.BindingSource profissionalBindingSource;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox IdEdicaoTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn EditarColumn;
		private System.Windows.Forms.Button HoraExtraButton;
	}
}

