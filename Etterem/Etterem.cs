using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
	internal class Etterem
	{
		public List<MenuElem> Menu { get; set; }
		public List<Rendeles> Rendelesek { get; set; }


		public Etterem() 
		{ 
		 Menu = new List<MenuElem>();
		 Rendelesek = new List<Rendeles>();
		}

		public void HozzadMenu(MenuElem menuElem)
		{
			Menu.Add(menuElem);
			Console.WriteLine($"A(z) {menuElem.Nev} nevű termék hozzálett adva a menühöz");
		}

		public void Listazmenut()
		{
			Console.WriteLine("A menü:");
			foreach (var menuElem in Menu)
			{
				Console.WriteLine(menuElem.ToString());
			}
		}


		public void Ujrendeles(Vendeg vendeg)
		{
			var rendeles = new Rendeles(vendeg);
			Rendelesek.Add(rendeles);
		}




	}
}
