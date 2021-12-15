
namespace CRUDStudiosTI
{
	partial class HoraExtraForm
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
			this.ProfissionalComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SalarioTextBox = new System.Windows.Forms.TextBox();
			this.QntdHorasExtrasTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.CalcularButton = new System.Windows.Forms.Button();
			this.SalarioEHorasExtrasTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ProfissionalComboBox
			// 
			this.ProfissionalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProfissionalComboBox.FormattingEnabled = true;
			this.ProfissionalComboBox.Location = new System.Drawing.Point(117, 49);
			this.ProfissionalComboBox.Name = "ProfissionalComboBox";
			this.ProfissionalComboBox.Size = new System.Drawing.Size(407, 21);
			this.ProfissionalComboBox.TabIndex = 0;
			this.ProfissionalComboBox.SelectedIndexChanged += new System.EventHandler(this.ProfissionalComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Profissional";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(170, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Salário";
			// 
			// SalarioTextBox
			// 
			this.SalarioTextBox.Enabled = false;
			this.SalarioTextBox.Location = new System.Drawing.Point(220, 107);
			this.SalarioTextBox.Name = "SalarioTextBox";
			this.SalarioTextBox.Size = new System.Drawing.Size(165, 20);
			this.SalarioTextBox.TabIndex = 3;
			// 
			// QntdHorasExtrasTextBox
			// 
			this.QntdHorasExtrasTextBox.Location = new System.Drawing.Point(220, 144);
			this.QntdHorasExtrasTextBox.Name = "QntdHorasExtrasTextBox";
			this.QntdHorasExtrasTextBox.Size = new System.Drawing.Size(165, 20);
			this.QntdHorasExtrasTextBox.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(121, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Qntd Horas Extras";
			// 
			// CalcularButton
			// 
			this.CalcularButton.Location = new System.Drawing.Point(407, 142);
			this.CalcularButton.Name = "CalcularButton";
			this.CalcularButton.Size = new System.Drawing.Size(75, 23);
			this.CalcularButton.TabIndex = 6;
			this.CalcularButton.Text = "Calcular";
			this.CalcularButton.UseVisualStyleBackColor = true;
			this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
			// 
			// SalarioEHorasExtrasTextBox
			// 
			this.SalarioEHorasExtrasTextBox.Enabled = false;
			this.SalarioEHorasExtrasTextBox.Location = new System.Drawing.Point(220, 215);
			this.SalarioEHorasExtrasTextBox.Name = "SalarioEHorasExtrasTextBox";
			this.SalarioEHorasExtrasTextBox.Size = new System.Drawing.Size(165, 20);
			this.SalarioEHorasExtrasTextBox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(254, 199);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Salário + Horas Extras";
			// 
			// HoraExtraForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 279);
			this.Controls.Add(this.SalarioEHorasExtrasTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.CalcularButton);
			this.Controls.Add(this.QntdHorasExtrasTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.SalarioTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ProfissionalComboBox);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HoraExtraForm";
			this.ShowIcon = false;
			this.Text = "Hora Extra";
			this.Load += new System.EventHandler(this.HoraExtraForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox ProfissionalComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox SalarioTextBox;
		private System.Windows.Forms.TextBox QntdHorasExtrasTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button CalcularButton;
		private System.Windows.Forms.TextBox SalarioEHorasExtrasTextBox;
		private System.Windows.Forms.Label label4;
	}
}