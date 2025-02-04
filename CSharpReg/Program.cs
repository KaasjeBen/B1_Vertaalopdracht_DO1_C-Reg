using System;

class Program
{
    static void Main(string[] args)
    {
        // Start programma, stel de nodige variabelen in
        Console.WriteLine("========== C#Reg ===========");
        Console.WriteLine("Welkom bij C#Reg, het C# KassaSysteem voor en door DeveloperLand!");
        Console.WriteLine("Tel de kassa, en geef op hoeveel er nu in zit.");
        Console.Write("Bedrag in kassa? ");
        double bedragInKassaBegin = Convert.ToDouble(Console.ReadLine());
        int keuze = 0;
        double dagTotaal = 0;
        int aantalBonnen = 0;
        double dagTotaalTerug = 0;

        // Herhaal tot de gebruiker aangeeft dat het programma afgesloten moet worden
        while (keuze != 9)
        {
            Console.Clear();
            Console.WriteLine("======== HOOFDMENU =========");
            Console.WriteLine("1. Nieuwe bon");
            Console.WriteLine("2. Retour");
            Console.WriteLine("3. Toon kassatotaal");
            Console.WriteLine("9. Afsluiten");
            Console.WriteLine("============================");

            Console.Write("Maak uw keuze en druk op <ENTER>: ");
            keuze = Convert.ToInt32(Console.ReadLine());

            if (keuze == 1)
            {
                int bestelKeuze = 0;
                double bonTotaal = 0;
                string bonString = "";
                while (bestelKeuze != 9)
                {
                    Console.Clear();
                    Console.WriteLine("========= BON MENU =========");
                    Console.WriteLine("Bon " + aantalBonnen);
                    Console.WriteLine("1. Volwassene                     € 19,-");
                    Console.WriteLine("2. Kinderen tot 12jr              € 9,-");
                    Console.WriteLine("3. Familiepas (2x volw. 3x kind)  € 49");
                    Console.WriteLine("4. DeveloperLand-kaart            € 4,50");
                    Console.WriteLine("5. Kinderwagen/bolderkar (1 dag)  € 6");
                    Console.WriteLine("6. Parkeerdagkaart                € 9");
                    Console.WriteLine("9. Afronden bon");
                    Console.WriteLine("Z. Bon annuleren");
                    Console.WriteLine("============================");

                    Console.Write("Maak uw keuze en druk op <ENTER>: ");
                    string bestelKeuzeString = Console.ReadLine();
                    bestelKeuze = Convert.ToInt32(bestelKeuzeString);

                    if (bestelKeuze == 1)
                    {
                        bonTotaal += 19;
                        bonString += "1x Volwassene                  € 19\r\n";
                    }
                    else if (bestelKeuze == 2)
                    {
                        bonTotaal += 9;
                        bonString += "1x kind (tot 12jr)             € 9\r\n";
                    }
                    else if (bestelKeuze == 3)
                    {
                        bonTotaal += 49;
                        bonString += "1x Familiepas                  € 49\r\n";
                    }
                    else if (bestelKeuze == 4)
                    {
                        bonTotaal += 4.50;
                        bonString += "1x Parkkaart                   € 4,50\r\n";
                    }
                    else if (bestelKeuze == 5)
                    {
                        bonTotaal += 6;
                        bonString += "1x kinderwagen/bolderkarhuur   € 6\r\n";
                    }
                    else if (bestelKeuze == 6)
                    {
                        bonTotaal += 9;
                        bonString += "1x Parkeerdagkaart             € 9\r\n";
                    }
                    else if (bestelKeuze == 9)
                    {
                        aantalBonnen += 1;
                        dagTotaal += bonTotaal;
                        Console.WriteLine(bonString);
                        Console.WriteLine("======== BON TOTAAL ========");
                        Console.WriteLine("Te betalen: " + bonTotaal);
                        Console.Write("Betaald: ");
                        double betaald = Convert.ToDouble(Console.ReadLine());
                        double terug = bonTotaal - betaald;
                        Console.WriteLine("Terug: " + terug);
                        Console.WriteLine("Druk op <ENTER> om door te gaan.");
                        Console.ReadLine();
                    }
                    else if (bestelKeuzeString.ToUpper() == "Z")
                    {
                        bestelKeuze = 9;
                        bonTotaal = 0;
                        bonString = "";
                    }
                }
            }
            else if (keuze == 2)
            {
                Console.WriteLine("Uitvoeren terugbetaling");
                Console.Write("Bedrag originele bon: ");
                double terugTeGeven = Convert.ToDouble(Console.ReadLine());
                Console.Write("Reden retour: ");
                string reden = Console.ReadLine();
                dagTotaalTerug = terugTeGeven;
            }
            else if (keuze == 3)
            {
                Console.Clear();
                Console.WriteLine("======= DAG TOTALEN ========");
                Console.WriteLine("In kassa begin:   " + bedragInKassaBegin);
                Console.WriteLine("Verkocht:         " + dagTotaal);
                Console.WriteLine("Retour:           " + dagTotaalTerug);
                Console.WriteLine("In kassa:         " + (bedragInKassaBegin + dagTotaal - dagTotaalTerug));
                Console.WriteLine("Druk op <ENTER> om door te gaan.");
                Console.ReadLine();
            }
        }

        double inKassa;
        Console.Write("Hoeveel zit er nu in de kassa? ");
        inKassa = Convert.ToDouble(Console.ReadLine());

        // Herhaal zolang het opgegeven bedrag in kassa niet overeenkomt met het berekende bedrag in kassa
        while (inKassa != (bedragInKassaBegin + dagTotaal - dagTotaalTerug))
        {
            Console.WriteLine("Je hebt een kassaverschil! Tel de kassa opnieuw.");
            Console.Write("Hoeveel zit er nu in de kassa? ");
            inKassa = Convert.ToDouble(Console.ReadLine());
        }

        Console.Clear();
        Console.WriteLine("Kassa klopt, programma wordt afgesloten.");

        // Toon dagtotalen
        Console.WriteLine("======== DAGTOTALEN ========");
        Console.WriteLine("Aantal bonnen: " + aantalBonnen);
        Console.WriteLine("Verkocht:      " + dagTotaal);
        Console.WriteLine("Totaal retour: " + dagTotaalTerug);
        Console.WriteLine("In kassa:      " + inKassa);
        Console.WriteLine("============================");
    }
}
//kaas