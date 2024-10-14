using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaDespesas
{
	internal class GerenciadorDeDados
	{
		private static string caminhoArquivo = "jsonArc/dados.json";

		public static void SalvarDados(Despesa despesa)
		{
			try
			{
				string json = JsonConvert.SerializeObject(despesa, Formatting.Indented);
				File.WriteAllText(caminhoArquivo, json);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro ao salvar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static Despesa CarregarDados()
		{
			try
			{
				if (!File.Exists(caminhoArquivo))
					return new Despesa();

				string json = File.ReadAllText(caminhoArquivo);
				Despesa despesa = JsonConvert.DeserializeObject<Despesa>(json) ?? new Despesa();
				despesa.calculaTotalSaldo();
				return despesa;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new Despesa();
			}
		}
	}
}
