using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
	internal class Fajlkezelo
	{
		private const string Menufajl = "menu.txt";
		private const string Rendelesfajl = "rendeles.txt";

		public static List<MenuElem> MenuBetoltese()
		{
			List<MenuElem> menu = new List<MenuElem>();
			if (File.Exists(Menufajl))
			{
				foreach (var sor in File.ReadAllLines(Menufajl))
				{
					var adatok = sor.Split(';');
					var menuk = new MenuElem(adatok[0], int.Parse(adatok[1]), adatok[2]);
					menu.Add(menuk);


				}
			}
			return menu;

		}

		public static void Menumentes(List<MenuElem> menu)
		{
			using (StreamWriter sw = new StreamWriter(Menufajl))
			{
				foreach(var menuk in menu)
				{
					sw.WriteLine($"{menuk.Nev};{menuk.Ar};{menuk.Kategoria};");
				}
			}
		}


		public static void Rendelesmentes(List<Rendeles> rendelesek)
		{
			using (StreamWriter sw = new StreamWriter(Rendelesfajl))
			{
				foreach (var rendeles in rendelesek)
				{
					string rendelesekstring = rendeles.ToString();
					sw.WriteLine($"{rendelesekstring}");
				}
			}
		}


	}
}
