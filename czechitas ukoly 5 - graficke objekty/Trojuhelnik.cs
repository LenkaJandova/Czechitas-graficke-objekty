using czechitas_ukoly_5___graficke_objekty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyechitas_ukoly_5___graficke_objekty
{
	internal class Trojuhelnik : GrafickyObjekt
	{
		public override void Vykreslit()
		{
			Console.WriteLine("  #");
			Console.WriteLine(" ###");
			Console.WriteLine("#####");
		}
	}
}
