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
	public partial class ProfissionalForm : Form
	{
		public ProfissionalForm()
		{
			InitializeComponent();
		}

		private void GravarButton_Click(object sender, EventArgs e)
		{
			var nome = NomeCompletoTextBox.Text;
			var telefone = TelefoneTextBox.Text;
			var rg = RGTextBox.Text;
			var endereco = EnderecoTextBox.Text;
			var salario = SalarioTextBox.Text;

			try
			{
				if (string.IsNullOrWhiteSpace(nome))
				{
					throw new Exception("Preencha o Nome!");
				}

				if (string.IsNullOrWhiteSpace(telefone))
				{
					throw new Exception("Preencha o Telefone!");
				}

				if (string.IsNullOrWhiteSpace(rg))
				{
					throw new Exception("Preencha o RG!");
				}

				if (string.IsNullOrWhiteSpace(endereco))
				{
					throw new Exception("Preencha o Endereço!");
				}

				if (string.IsNullOrWhiteSpace(salario))
				{
					throw new Exception("Preencha o Salário!");
				}

				decimal dblSalario = 0;

				if (!decimal.TryParse(salario, out dblSalario))
				{
					throw new Exception("Preencha o Salário Corretamente!");
				}

				var intIdEdicao = 0;

				int.TryParse(IdEdicaoTextBox.Text, out intIdEdicao);

				using (var ctx = new CRUDStudiosTIEntities())
				{
					if (intIdEdicao > 0)
					{
						var profissional = ctx.Profissionals.First(x => x.Id == intIdEdicao);

						profissional.Endereco = endereco;
						profissional.NomeCompleto = nome;
						profissional.RG = rg;
						profissional.Salario = dblSalario;
						profissional.Telefone = telefone;
					}
					else
					{
						ctx.Profissionals.Add(new Profissional()
						{
							Endereco = endereco,
							NomeCompleto = nome,
							RG = rg,
							Salario = dblSalario,
							Telefone = telefone
						});
					}

					ctx.SaveChanges();
				}

				ExcluirButton.Enabled = false;

				LimparCampos();
				PopularGrid();

				MessageBox.Show("Dados Salvos com sucesso");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void LimparCampos()
		{
			NomeCompletoTextBox.Text = string.Empty;
			TelefoneTextBox.Text = string.Empty;
			RGTextBox.Text = string.Empty;
			EnderecoTextBox.Text = string.Empty;
			SalarioTextBox.Text = string.Empty;
			IdEdicaoTextBox.Text = string.Empty;
		}

		public void PopularGrid()
		{
			using (var ctx = new CRUDStudiosTIEntities())
			{
				var lista = ctx.Profissionals.ToList();

				ProfissionalDataGridView.DataSource = lista;
			}
		}

		private void ExcluirButton_Click(object sender, EventArgs e)
		{
			using (var ctx = new CRUDStudiosTIEntities())
			{
				var intId = Convert.ToInt32(Convert.ToInt32(IdEdicaoTextBox.Text));

				var profissional = ctx.Profissionals.First(x => x.Id == intId);
				ctx.Profissionals.Remove(profissional);
				ctx.SaveChanges();
			}

			ExcluirButton.Enabled = false;

			LimparCampos();
			PopularGrid();
		}

		private void ProfissionalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var id = Convert.ToString(ProfissionalDataGridView.Rows[e.RowIndex].Cells[0].Value);
				var intId = Convert.ToInt32(id);

				using (var ctx = new CRUDStudiosTIEntities())
				{
					var profissional = ctx.Profissionals.First(x => x.Id == intId);

					NomeCompletoTextBox.Text = profissional.NomeCompleto;
					TelefoneTextBox.Text = profissional.Telefone;
					RGTextBox.Text = profissional.RG;
					EnderecoTextBox.Text = profissional.Endereco;
					SalarioTextBox.Text = profissional.Salario.ToString();
					IdEdicaoTextBox.Text = id;
				}

				ExcluirButton.Enabled = true;
			}
		}

		private void ProfissionalForm_Load(object sender, EventArgs e)
		{
			PopularGrid();
		}

		private void HoraExtraButton_Click(object sender, EventArgs e)
		{
			var form = new HoraExtraForm();
			form.ShowDialog();
		}
	}
}
