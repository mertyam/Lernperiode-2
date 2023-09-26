using System;
using System.Collections.Generic;

namespace Radom_Witz_Generator
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            List<string> flat = new List<string>()
           {
               "Was ist rot und schlecht für die Zähne? – Ein Ziegelstein",
               "Was ist die Mehrzahl von Rettich? – Meerrettich",
               "Was hat vier Beine und kann fliegen? – Zwei Vögel",
               "Ich stecke gerade in der Bredouille! – Wie schön, Frankreich!",
               "Was sagt ein Polizist mit sächsischem Dialekt? – „Ägyptisch oder ich schieße.“",
               "Geht ein Neutron in die Disco. Sagt der Türsteher: „Nur für geladene Gäste!“",
               "Wann gehen U-Boote unter? – Am Tag der offenen Tür",
               "Was ist die Lieblingsspeise von Piraten? – Kapern",
               "Meister Yoda, können Sie was zum schiefen Turm von Pisa sagen? – „Gerade nicht.“",
               "Warum klaut Robin Hood Deodorant? – Um es unter den Armen zu verteilen",
               "Meine Oma ist Griechin. – „Ach, Feta-licherseits?“",
               "Wie nennt man jemanden, der so tut, als würde er etwas werfen? – Scheinwerfer",
               "Treffen sich zwei Kerzen: Sagt die eine zur anderen: „Gehen wir heute aus?“",
               "Was passiert, wenn man Cola und Bier trinkt? – Man colabiert",
               "Treffen sich zwei Magnete, sagt der eine: „Was soll ich heute bloß anziehen?“",
               "War heute ohne Handy auf Toilette… Wir haben 167 Fliesen.",
               "Hast du was zu trinken? – Wasser. – Nee, was Härteres! – Ok, Eis."
           };

            List<string> black = new List<string>()
           {
               "Die ersten Worte meines Sohnes waren: 'Wo warst du die letzten 18 Jahre?'",
               "Was ist gemein? 'Einem Blinden eine Kinokarte zu schenken.'",
               "Und was ist fies? 'Wenn es ein Stummfilm ist.'",
               "Neulich im Vorstellungsgespräch: 'Stellen Sie mich ein! Schon 3 Konzerne sind hinter mir her…' – 'Ach, welche denn?' – 'Gas, Strom und Wasser.'",
               "Was machst du, wenn dir ein Leprakranker die Hand gibt? – 'Du gibst sie ihm zurück!'",
               "Witze über Rollstuhlfahrer sind voll das No-Go!",
               "Was ist der Unterschied zwischen einem Arzt und einem Polen? 'Der Pole weiß, was dir fehlt!'",
               "Der Kleine 'Verpiss-dich-mein-Name-geht-dich-nichts-an' möchte aus dem Kinderparadies abgeholt werden.",
               "Arzt: 'Sie haben noch 10 zu leben.' Patient: '10 was? Monate? Jahre?' Arzt: 'Neun…'",
               "Wie war die Stimmung in der DDR? – 'Sie hielt sich in Grenzen!'",
               "Was lernt man bei der französischen Armee als Erstes? – 'In 10 Sprachen zu kapitulieren.'"
           };

            Console.WriteLine("Welche Art von Witzen willst du hören?");
            Console.WriteLine("A Flachwitze");
            Console.WriteLine("B Schwarzer Humor");
            string auswahl = Console.ReadLine();
            Console.Clear();
            if (auswahl.ToUpper() == "A")
            {
                Random rnd = new Random();
                int randIndex = rnd.Next(flat.Count);
                string random = flat[randIndex];
                Console.WriteLine(random);
            }
            else if (auswahl.ToUpper() == "B")
            {
                Random rnd = new Random();
                int randIndex = rnd.Next(black.Count);
                string random = black[randIndex];
                Console.WriteLine(random);
            }

            while (true)
            {
                Console.WriteLine(
                    );
                Console.WriteLine("Willst du noch einen Witz hören?");
                Console.WriteLine("Ja");
                Console.WriteLine("Nein");

                string frage = Console.ReadLine();
                Console.Clear();


                if (frage.ToUpper() == "JA")
                {
                    Console.WriteLine("Welche Art von Witzen willst du hören?");
                    Console.WriteLine("A Flachwitze");
                    Console.WriteLine("B Schwarzer Humor");
                    auswahl = Console.ReadLine();
                    Console.Clear( );
                    if (auswahl.ToUpper() == "A")
                    {
                        Random rnd = new Random();
                        int randIndex = rnd.Next(flat.Count);
                        string random = flat[randIndex];
                        Console.WriteLine(random);
                    }
                    else if (auswahl.ToUpper() == "B")
                    {
                        Random rnd = new Random();
                        int randIndex = rnd.Next(black.Count);
                        string random = black[randIndex];
                        Console.WriteLine(random);
                    }
                }
                else if (frage.ToUpper() == "NEIN")
                {
                    throw new Exception();
                } 
            }
        }
    }
}
