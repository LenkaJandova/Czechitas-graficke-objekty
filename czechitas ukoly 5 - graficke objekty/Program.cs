using cyechitas_ukoly_5___graficke_objekty;
using czechitas_ukoly_5___graficke_objekty;
using System.Runtime.CompilerServices;

GrafickyObjekt g = new GrafickyObjekt();
//g.Vykreslit();

//Console.WriteLine("");

Obdelnik o = new Obdelnik();
Trojuhelnik tr = new Trojuhelnik();
Text t = new Text();

List<GrafickyObjekt> list = new List<GrafickyObjekt>() { o, tr, t};

//foreach (GrafickyObjekt obj in list) 
//{
//	obj.Vykreslit();
//	Console.WriteLine(" ");
//}

o.Vykreslit(3,5);
