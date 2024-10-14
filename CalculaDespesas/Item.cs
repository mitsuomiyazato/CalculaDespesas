using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaDespesas
{
	internal class Item
	{
		private String _nome;
		private double _valor;
		private int _tipo;

		public Item(String _nome = "", double _valor = 0, int _tipo = 0)
		{
			this._nome = _nome;
			this._valor = _valor;
			this._tipo = _tipo;
		}

		public String Nome
		{
			get { return _nome;}
			set { _nome = value; }
		}

		public double Valor
		{
			get { return _valor; }
			set { _valor = value; }
		}

		public int Tipo
		{
			get { return _tipo; }
			set { _tipo = value; }
		}
	}
}
