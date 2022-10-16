using czechitas_ukoly_5___graficke_objekty;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cyechitas_ukoly_5___graficke_objekty
{
	internal class Obdelnik : GrafickyObjekt
	{
		public override void Vykreslit()
		{
			Console.WriteLine("###");
			Console.WriteLine("###");
			Console.WriteLine("###");
		}

		public void Vykreslit(int vyska, int sirka)
		{
			int Vyska = vyska;
			int Sirka = sirka;

			for (int i = 0; i < vyska; i++)
			{
				string radek = string.Empty;
				for (int j = 0; j < sirka; j++)
				{
					radek = radek + "#";
				}
				Console.WriteLine($"{radek}");
			}
		}
		
	}
}
