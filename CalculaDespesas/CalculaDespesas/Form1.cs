using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaDespesas
{
	public partial class Despesas : Form
	{
		Despesa despesa;

		public Despesas()
		{
			InitializeComponent();
			despesa = GerenciadorDeDados.CarregarDados() ?? new Despesa();
			AtualizarInterface();
		}

		private void AtualizarInterface()
		{
			gridLucro.Rows.Clear();
			gridDespesa.Rows.Clear();

			foreach (Item itemLista in despesa.ListaLucro)
			{
				gridLucro.Rows.Add(itemLista.Nome, itemLista.Valor);
			}

			foreach (Item itemLista in despesa.ListaDespesa)
			{
				gridDespesa.Rows.Add(itemLista.Nome, itemLista.Valor);
			}

			TxtSaldo.Text = despesa.TotalSaldo.ToString("C", CultureInfo.CurrentCulture);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string nome = txtName.Text;
			string valorTexto = mskTxtValue.Text.Replace(",", ".");
			double valor;

			if (string.IsNullOrWhiteSpace(valorTexto) || !double.TryParse(valorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
			{
				MessageBox.Show(
					"Por favor, insira um valor válido.",
					"Aviso",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
				return;
			}

			int tipo;
			Item item;

			if (string.IsNullOrWhiteSpace(nome) || valor == 0)
			{
				MessageBox.Show(
					"Nome ou valor nulo. Por favor, preencha com valores válidos",
					"Aviso",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
			}
			else
			{
				if (rdbBtnType1.Checked)
				{
					item = new Item(nome, valor, 0);
				}
				else
				{
					item = new Item(nome, valor, 1);
				}
				despesa.addItemList(item);
			}

			gridLucro.Rows.Clear();
			gridDespesa.Rows.Clear();
			foreach (Item itemLista in despesa.ListaLucro)
			{
				gridLucro.Rows.Add(itemLista.Nome, itemLista.Valor);
			}
			foreach (Item itemLista in despesa.ListaDespesa)
			{
				gridDespesa.Rows.Add(itemLista.Nome, itemLista.Valor);
			}

			TxtSaldo.Text = despesa.TotalSaldo.ToString("C", CultureInfo.CurrentCulture);
			txtName.Text = "";
			mskTxtValue.Text = "";

			GerenciadorDeDados.SalvarDados(despesa);
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			bool itemExcluido = false;

			if (gridLucro.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow selectedRow in gridLucro.SelectedRows)
				{
					string itemName = selectedRow.Cells[0].Value.ToString();
					Item itemdel = despesa.ListaLucro.FirstOrDefault(item => item.Nome.Equals(itemName));

					if (itemdel != null)
					{
						despesa.delItem(itemdel);
						itemExcluido = true;
					}

					gridLucro.Rows.Remove(selectedRow);
				}
			}

			if (gridDespesa.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow selectedRow in gridDespesa.SelectedRows)
				{
					string itemName = selectedRow.Cells[0].Value.ToString();
					Item itemdel = despesa.ListaDespesa.FirstOrDefault(item => item.Nome.Equals(itemName));

					if (itemdel != null)
					{
						despesa.delItem(itemdel);
						itemExcluido = true;
					}

					gridDespesa.Rows.Remove(selectedRow);
				}
			}

			if (itemExcluido)
			{
				TxtSaldo.Text = despesa.TotalSaldo.ToString("C", CultureInfo.CurrentCulture);

				GerenciadorDeDados.SalvarDados(despesa);
			}
			else
			{
				MessageBox.Show(
					"Nenhum item selecionado. Por favor, selecione um item para excluir.",
					"Aviso",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);
			}
		}


		private void btnLimpar_Click(object sender, EventArgs e)
		{
			despesa = new Despesa();


			gridLucro.Rows.Clear();
			gridDespesa.Rows.Clear();

			TxtSaldo.Text = "R$ 0,00";

			txtName.Text = "";
			mskTxtValue.Text = "";

			GerenciadorDeDados.SalvarDados(despesa);
		}


		private void btnCopiar_Click(object sender, EventArgs e)
		{
			string copiedText =
				"*DESPESAS*\n\nLucro-->";

			foreach (Item itemShow in despesa.ListaLucro)
			{
				copiedText += "\n" + itemShow.Nome + ": +R$ " + itemShow.Valor.ToString("C", CultureInfo.CurrentCulture);
			}

			copiedText += "\n\nDespesa-->";

			foreach (Item itemShow in despesa.ListaDespesa)
			{
				copiedText += "\n" + itemShow.Nome + ": -R$ " + itemShow.Valor.ToString("C", CultureInfo.CurrentCulture);
			}

			copiedText += "\n\nSaldo: " + despesa.TotalSaldo.ToString("C", CultureInfo.CurrentCulture);

			Clipboard.SetText(copiedText);
			MessageBox.Show("Texto copiado para o clipboard.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
