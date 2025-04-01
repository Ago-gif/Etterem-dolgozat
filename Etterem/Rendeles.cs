using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
	internal class Rendeles
	{
		public Vendeg Vendeg {  get; set; }
		public List<MenuElem> Etelek {  get; set; }
		
		public Rendeles(Vendeg vendeg)
		{
			Vendeg = vendeg;
			Etelek = new List<MenuElem>(vendeg.Rendeltetelek);
		}

		public int fizetes()
		{
			int osszesen = 0;
			foreach (MenuElem e in Etelek)
			{
				osszesen += e.Ar;
			}
			return osszesen;
		}


		public override string ToString()
		{
			string rendelesekstring = string.Join(", ", Etelek.Select(m => m.Nev));
			return $"Név: {Vendeg.Vendegnev}, Rendelés:{rendelesekstring}, Végösszeg:{fizetes()}";
		}

	}
}
