using System;

class Avonturenspel
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welkom bij het Avonturenspel!");
        Console.WriteLine("Je bevindt je voor de ingang van een mysterieuze grot...");
        Console.WriteLine("Wil je de grot binnengaan? (ja/nee)");
        string keuze = Console.ReadLine().ToLower();

        if (keuze == "ja")
        {
            Console.WriteLine("Je stapt voorzichtig de grot binnen...");
            Console.WriteLine("Terwijl je dieper gaat, kom je bij een splitsing in het pad.");
            Console.WriteLine("Wil je naar links of rechts gaan? (links/rechts)");
            string richting = Console.ReadLine().ToLower();

            if (richting == "links")
            {
                Console.WriteLine("Je kiest ervoor om naar links te gaan. Je komt een slapende draak tegen!");
                Console.WriteLine("Wil je tegen de draak vechten of er stilletjes langs sluipen? (vechten/sluipen)");
                string actie = Console.ReadLine().ToLower();

                if (actie == "vechten")
                {
                    Console.WriteLine("Je valt moedig de draak aan, maar hij is te krachtig en verslaat je...");
                    Console.WriteLine("Spel voorbij!");
                }
                else if (actie == "sluipen")
                {
                    Console.WriteLine("Je sluipt stilletjes langs de draak, voorzichtig om hem niet wakker te maken...");
                    Console.WriteLine("Je bent de draak succesvol gepasseerd en gaat verder met je avontuur!");
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze. Spel voorbij!");
                }
            }
            else if (richting == "rechts")
            {
                Console.WriteLine("Je kiest ervoor om naar rechts te gaan. Je stuit op een schatkist!");
                Console.WriteLine("Wil je de schatkist openen? (ja/nee)");
                string openKist = Console.ReadLine().ToLower();

                if (openKist == "ja")
                {
                    Console.WriteLine("Je opent de schatkist en vindt een stapel gouden munten!");
                    Console.WriteLine("Gefeliciteerd, je hebt de schat gevonden! Je wint!");
                }
                else if (openKist == "nee")
                {
                    Console.WriteLine("Je besluit de schatkist niet te openen en gaat verder met je reis.");
                    Console.WriteLine("Je gaat dieper de grot in...");
                    Console.WriteLine("Helaas verdwaal je in de grot en vind je nooit meer de uitgang. Spel voorbij!");
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze. Spel voorbij!");
                }
            }
            else
            {
                Console.WriteLine("Ongeldige keuze. Spel voorbij!");
            }
        }
        else if (keuze == "nee")
        {
            Console.WriteLine("Je besluit de grot niet binnen te gaan en gaat elders verder met je reis...");
            Console.WriteLine("Spel voorbij!");
        }
        else
        {
            Console.WriteLine("Ongeldige keuze. Spel voorbij!");
        }
    }
}
