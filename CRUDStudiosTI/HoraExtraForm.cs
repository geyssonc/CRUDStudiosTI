using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDStudiosTI
{
	public partial class HoraExtraForm : Form
	{
		public HoraExtraForm()
		{
			InitializeComponent();
		}

		private void CalcularButton_Click(object sender, EventArgs e)
		{
			var salario = Convert.ToDouble(SalarioTextBox.Text);

			try
			{
				var intHorasExtras = 0;

				if (!int.TryParse(QntdHorasExtrasTextBox.Text, out intHorasExtras))
				{
					throw new Exception("Preencha a quantidade de horas extras apenas com números inteiros");
				}

				var percSalario = salario * (5.0 / 100);
				salario += percSalario * intHorasExtras;

				SalarioEHorasExtrasTextBox.Text = salario.ToString("N2");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ProfissionalComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			LimparCampos();

			var dblValor = 0d;

			if (double.TryParse(ProfissionalComboBox.SelectedValue.ToString(), out dblValor))
			{
				SalarioTextBox.Text = dblValor.ToString("N2");
			}			
		}

		private void HoraExtraForm_Load(object sender, EventArgs e)
		{
			LimparCampos();

			using (var ctx = new CRUDStudiosTIEntities())
			{
				var lista = ctx.Profissionals.ToList();

				lista.Insert(0, new Profissional() { NomeCompleto = "Selecione", Salario = 0 });

				ProfissionalComboBox.DataSource = new BindingSource(lista, null);
				ProfissionalComboBox.DisplayMember = "NomeCompleto";
				ProfissionalComboBox.ValueMember = "Salario";
			}
		}

		private void LimparCampos()
		{
			QntdHorasExtrasTextBox.Text = string.Empty;
			SalarioEHorasExtrasTextBox.Text = string.Empty;
		}
	}
}