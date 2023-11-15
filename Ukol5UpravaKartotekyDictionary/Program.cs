using Ukol5UpravaKartoteky;

/*
 * Zadání:
Kartotéku, která byla úkolem v minulých lekcích uprav na použití s dictionary. 
Nezapomeň vhodně zvolit klíčovou hodnotu pro dictionary.
*/

var mojeKnihy = new Dictionary <Kniha,Autor>();
bool jeKonec = false;

while (!jeKonec)
{
    Console.WriteLine("Moje knihy - menu:");
    Console.WriteLine("1-Přidat knihu");
    Console.WriteLine("2-Smazat knihu");
    Console.WriteLine("3-Vypsat knihy");
    Console.WriteLine("0-Konec");
    Console.Write("Zadej volbu :");

    int menu = Convert.ToInt32(Console.ReadLine());

    switch (menu)
    {
        case 0:
            jeKonec = true;
            break;
        case 1:
            Kniha zadanaKniha = new Kniha();
            Autor zadanyAutor = new Autor();

            Console.Write("Zadej nazev knihy: ");
            zadanaKniha.Nazev = Console.ReadLine();
            Console.Write("Zadej rok vydání: ");
            zadanaKniha.RokVydani = Console.ReadLine();

            Console.Write("Zadej příjmení autora: ");
            zadanyAutor.Prijmeni = Console.ReadLine();
            Console.Write("Zadej jméno autora: ");
            zadanyAutor.Jmeno = Console.ReadLine();

            mojeKnihy.Add(zadanaKniha,zadanyAutor);
            break;
        case 2:
            Kniha smazatKnihu = new Kniha();
            Console.Write("Zadej nazev knihy: ");
            smazatKnihu.Nazev = Console.ReadLine();
            Console.Write("Zadej rok vydání: ");
            smazatKnihu.RokVydani = Console.ReadLine();

            if (mojeKnihy.ContainsKey(smazatKnihu))
            {
                mojeKnihy.Remove(smazatKnihu);
            }
            else
            {
                Console.WriteLine("Mazání přerušeno: zadaný klíč neexistuje.");
            }

            break;
        case 3:
            int i = 1;
            foreach (KeyValuePair<Kniha, Autor> item in mojeKnihy)
            {
                Console.WriteLine($"{i}\t {item.Key.Nazev} \t {item.Key.RokVydani} \t {item.Value.Jmeno} \t {item.Value.Prijmeni}");
                i++;
            }
                
            
            break;

    }
}
