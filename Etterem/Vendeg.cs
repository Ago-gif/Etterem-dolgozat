using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
	internal class Vendeg
	{
		public string Vendegnev { get; set; }
		public int Osszar { get; private set; }

		public List<MenuElem> Rendeltetelek { get; set; } 

		public Vendeg(string vendegnev)
		{
			Vendegnev  = vendegnev;
			Osszar = 0;
			Rendeltetelek = new List<MenuElem>();
		}

		public void Rendel(MenuElem etel)
		{
			Console.WriteLine($"Sikeresen megrendelted a(z) {etel.Nev} terméket, {etel.Ar} Forintért");
			Osszar += etel.Ar;
			Rendeltetelek.Add( etel );
		}

		public void Fizetes()
		{
			if (Rendeltetelek.Count == 0) 
			{
				Console.WriteLine("Nincs semmi megrendelve, nem lehet fizetni!");
			}
			else
			{
			Rendeltetelek.Clear();
			}
			
		}

		public void Rendeleskiiras()
		{
			Console.WriteLine("A rendeléseid a következők: ");

			foreach ( var elem in Rendeltetelek)
			{
				Console.WriteLine($"{elem.Nev}, {elem.Kategoria}, {elem.Ar} Ft");
				

			}
		}
	}
}
