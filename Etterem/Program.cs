namespace Etterem
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Etterem etterem = new Etterem();
			etterem.Menu = Fajlkezelo.MenuBetoltese();

			Vendeg vendeg1 = new Vendeg("Kiss Péter");

			MenuElem burger = new MenuElem("Sajtburger", 1500, "Étel");
			MenuElem cola = new MenuElem("Kóla", 500, "Ital");

			etterem.HozzadMenu(burger);
			etterem.HozzadMenu(cola);

			etterem.Listazmenut();

			vendeg1.Rendel(burger);
			vendeg1.Rendel(cola);

			etterem.Ujrendeles(vendeg1);

			Fajlkezelo.Menumentes(etterem.Menu);
			Fajlkezelo.Rendelesmentes(etterem.Rendelesek);
		}
	}
}
