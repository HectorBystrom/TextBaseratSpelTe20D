using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBaseratSpelTe20D
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SpelTitel();
            Console.ReadLine();
        }
        static void SpelTitel()
        {
            Console.WriteLine("Spelet kring liv och död");
            Console.WriteLine("Klicka på \"Enter\" för att starta!");
            Console.ReadLine();
            Början();
        }
        static void Början()
        {
            Console.Clear();
            Console.WriteLine("Du går på en mörk kuslig stig och helt plötsligt delas stigen upp i 5 delar");
            Console.WriteLine("Till stigen längst till vänster så är det kol-svart och man ser ingenting");
            Console.WriteLine("Till stigen näst längst till vänster så är det en fågel som flyger framåt");
            Console.WriteLine("Till stigen näst längst till höger så hör man okända ljud");
            Console.WriteLine("Till stigen längst till höger så är det en främmande man som går där");

            int stigVal;
            Console.WriteLine();
            Console.WriteLine("Nu ska du välja väg, längst till vänster är 1 och längst till höger är 5");
            while (true)
            {

                try
                {
                    Console.Write("Vilken väg väljer du? ");
                    stigVal = int.Parse(Console.ReadLine());
                    if (stigVal < 1 || stigVal > 4)
                    {
                        Console.WriteLine("Ange en siffra inom spannet 1-5!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-5!");
                }
            }
            if (stigVal == 1)
            {
                StigValEtt();
            }
            else if (stigVal == 2)
            {
                StigValTvå();
            }
            else if (stigVal == 3)
            {
                StigValTre();
            }
            else if (stigVal == 4)
            {
                StigValFyra();
            }
        }
        static void StigValEtt()
        {
            Console.Clear();
            Console.WriteLine("Nu när du går på den mörka, mörka grusstigen så ser du en lampa längre fram, alldeles för sig självt.");
            Console.WriteLine("Till vänster om lampan finns ett mystiskt stort skräckjagande hus");
            Console.WriteLine("Nu finns det 2 alternativ");
            Console.WriteLine("1 Gå in i huset och utforska");
            Console.WriteLine("2 Fortsätta på den kol-svarta mystiska vägen");

            int husVägVal;
            Console.WriteLine();
            while (true)
            {
                try
                {
                    Console.Write("Vad väljer du? ");
                    husVägVal = int.Parse(Console.ReadLine());
                    if (husVägVal > 2 || husVägVal < 1)
                    {
                        Console.WriteLine("Välj 1 eller 2!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-2");
                }
            }
            if (husVägVal == 1)
            {
                HusVägValEtt();
            }
            if (husVägVal == 2)
            {
                HusVägValTvå();
            }
        }
        static void HusVägValEtt()
        {
            Console.Clear();
            Console.WriteLine("Du traskar in i det mörka läskiga huset");
            Console.WriteLine("Det finns en trappa upp och ned");
            Console.WriteLine("Det första alternativet är att gå upp för trappan");
            Console.WriteLine("Det andra alternativet är att gå ned för trappan");

            string trappaUppNed = "ned";
            Console.WriteLine();
            while (true)
            {
                try
                {
                    Console.Write("Vad väljer du? upp eller ned? ");
                    trappaUppNed = Console.ReadLine();
                    if (trappaUppNed == "ned" || trappaUppNed == "Ned" || trappaUppNed == "upp" || trappaUppNed == "Upp")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Något gick fel skriv in upp eller ned!");
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel skriv in upp eller ned!");
                }
            }
            if (trappaUppNed == "ned" || trappaUppNed == "Ned")
            {
                TrappaNed();
            }
            if (trappaUppNed == "upp" || trappaUppNed == "Upp")
            {
                TrappaUpp();
            }
        }
        static void HusVägValTvå()
        {
            Console.Clear();
            Console.WriteLine("Du fortsätter på den mystiska vägen tills du faller för ett stup.");
            Console.WriteLine("Klicka på \"Enter\" för att komma till slut skärmen.");
            Console.ReadLine();
        }
        static void TrappaNed()
        {
            Console.Clear();
            Console.WriteLine("Du går ned för trappan och den delas upp i 2 gångar, vilket gång väljer de? den högra eller vänstra");
            Console.WriteLine("Mata in 1 för höger och 2 för vänster");
            int trappaNedVal;
            Console.WriteLine();

            while (true)
            {
                try
                {
                    Console.Write("Vad väljer du? ");
                    trappaNedVal = int.Parse(Console.ReadLine());
                    if (trappaNedVal > 2 || trappaNedVal < 1)
                    {
                        Console.Write("Välj 1 eller 2!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-2");
                }
            }
            TrappaNedValBåda();
        }
        static void TrappaNedValBåda()
        {
            Console.Clear();
            Console.WriteLine("Du valde fel väg och blev uppslukad.");
            Console.WriteLine("Klicka på \"Enter\" för att komma till slut skärmen.");
            Console.ReadLine();
        }
        static void TrappaUpp()
        {
            Console.Clear();
            Console.WriteLine("Du går upp för trappan och kommer till tre lådor");
            Console.WriteLine("Dessa lådor slumpas och du väljer mellan 1, 2 och 3.");
            Console.WriteLine("Klicka på \"Enter\" för att få ditt val!");
            Console.ReadLine();
            while (true)
            {
                try
                {

                    Random random = new Random();
                    int num1 = random.Next(1, 4);
                    if (num1 == 1)
                    {
                        Console.WriteLine("Du förlorade då lådan blev 1");
                        Console.WriteLine("Klicka på \"Enter\" för att fortsätta till slutskärmen");
                        Console.ReadLine();
                        Förlust();
                    }
                    else if (num1 == 2)
                    {
                        Console.WriteLine("Du får en ny chans du hade låda 2 klicka på \"Enter\" för att göra om det");
                        Console.ReadLine();
                        TrappaUpp();
                    }
                    else if (num1 == 3)
                    {
                        RättLåda();
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, klicka på \"Enter\"!");
                }
            }
        }
        static void RättLåda()
        {
            Console.Clear();
            Console.WriteLine("Du hade turen med dig och fick rätt låda!");
            Console.WriteLine("Nu har du val möjligheten med att gå ut på balkongen och ta stegen ned eller fortsätta utforska i huset");
            Console.WriteLine("Alternativ 1 är att gå ut på balkongen och alternativ 2 är att stanna inne i huset");
            Console.WriteLine();
            int balkongEllerUtforska;
            while (true)
            {
                try
                {
                    Console.Write("Vad väljer du? ");
                    balkongEllerUtforska = int.Parse(Console.ReadLine());
                    if (balkongEllerUtforska > 2 || balkongEllerUtforska < 1)
                    {
                        Console.WriteLine("Välj 1 eller 2!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-2");
                }
            }
            if (balkongEllerUtforska == 1)
            {
                Balkong();
            }
            else if (balkongEllerUtforska == 2)
            {
                Utforska();
            }
        }
        static void Balkong()
        {
            Console.Clear();
            Console.WriteLine("Du går ut på balkongen och bestämmer dig för att gå tillbaka till de 5 vägarna där du åter igen bestämmer vart du vill gå! Klicka på \"Enter\" för att gå vidare");
            Console.ReadLine();
            Början();
        }
        static void Utforska()
        {
            Console.Clear();
            Console.WriteLine("Du bestämmer dig för att gå ned i huset i källaren! Klicka på \"Enter\" för att gå vidare");
            Console.ReadLine();
            TrappaNed();
        }
        static void StigValTvå()
        {
            Console.Clear();
            Console.WriteLine("Du följer den flygande fågeln tills du ser en cykel, du funderar på om du sak ta cykeln eller inte");
            Console.WriteLine("Alternativ 1 är att ta cykeln alternativ 2 är att fortsätta gå efter fågeln");
            Console.WriteLine();
            int cykelVägVal;
            while (true)
            {
                try
                {
                    Console.Write("Vad väljer du? ");
                    cykelVägVal = int.Parse(Console.ReadLine());
                    if (cykelVägVal > 2 || cykelVägVal < 1)
                    {
                        Console.WriteLine("Något gick fel! Välj 1 eller 2!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-2");
                }
            }
            if (cykelVägVal == 1)
            {
                CykelVägVal1();
            }
            if (cykelVägVal == 2)
            {
                CykelVägVal2();
            }
        }
        static void CykelVägVal2()
        {
            Console.Clear();
            Console.WriteLine("Du fortsätter gå men du börjar bli väldigt törstig och ser en sjö. Däremot kan vattnet i sjön vara farligt!");
            Console.WriteLine("Vad väljer du? Att dricka vattnet eller att fortsätta gå");
            Console.WriteLine("Alternativ 1 är att dricka vattnet och alternativ 2 är att fortsätta gå");
            Console.WriteLine();
            int sjöEllerGå;
            while (true)
            {
                try
                {
                    Console.Write("Skriv ditt val här: ");
                    sjöEllerGå = int.Parse(Console.ReadLine());
                    if (sjöEllerGå > 2 || sjöEllerGå < 1)
                    {
                        Console.WriteLine("Något gick fel! Välj 1 eller 2!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-2");
                }
            }
            if (sjöEllerGå == 1)
            {
                GiftigtVatten();
            }
            if (sjöEllerGå == 2)
            {
                Byn();
            }
        }
        static void CykelVägVal1()
        {
            Console.Clear();
            Console.WriteLine("Du tar cykeln och fortsätter följa fågeln, tillslut så hamnar du i en liten by");
            Console.WriteLine("Nu har du alternativet att stanna i byn eller fortsätta vidare!");
            Console.WriteLine("Skriv \"Stanna\" för att stanna och \"fortsätta\" för att fortsätta ");
            Console.WriteLine();
            String valStannaFortsätta = "fortsätta";
            while (true)
            {
                try
                {
                    Console.Write("Vad väljer du? stanna eller fortsätta? ");
                    valStannaFortsätta = Console.ReadLine();
                    if (valStannaFortsätta == "fortsätta" || valStannaFortsätta == "Fortsätta" || valStannaFortsätta == "stanna" || valStannaFortsätta == "Stanna")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Något gick fel skriv in upp eller ned!");
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel skriv in upp eller ned!");
                }
            }
            if (valStannaFortsätta == "fortsätta" || valStannaFortsätta == "Fortsätta")
            {
                Fortsätta();
            }
            if (valStannaFortsätta == "stanna" || valStannaFortsätta == "Stanna")
            {
                Console.WriteLine("Du börjar prata med folk för att få tag i vatten. Tyvärr lyckas du inte med det");
                Console.WriteLine("Klicka på \"Enter\" för at fortsätta");
                Console.ReadLine();
                Byn();
            }
        }
        static void Fortsätta()
        {
            Console.WriteLine("Du faller ned för ett stup.");
            Console.WriteLine("Du har förlorat klicka på \"Enter\" för att komma till slutskärmen");
            Console.ReadLine();
            Förlust();
        }
        static void GiftigtVatten()
        {
            Console.Clear();
            Console.WriteLine("Tyvärr så blev du förgiftad av vattnet");
            Console.WriteLine("Klicka på enter för att komma till slutskärmen.");
            Console.ReadLine();
            Förlust();
        }
        static void Byn()
        {
            Console.Clear();
            Console.WriteLine("Efter ett långt letande så hittar du en snäll familj som erbjuder mat och dricka.");
            Console.WriteLine("Du känner dig trygg i byn och stannar där över natten, däremot så vet du inte vart du ska sova");
            Console.WriteLine("Du frågade den snälla familjen men de hade inga platser över.");
            Console.WriteLine("Nu har du tre alternativ: 1 hålla dig vaken, 2 fråga runt och leta efter sovplatser, 3 bygg en koja och sov där");
            Console.WriteLine();
            int sovplats;
            while (true)
            {
                try
                {
                    Console.Write("Skriv ditt val här: ");
                    sovplats = int.Parse(Console.ReadLine());
                    if (sovplats > 3 || sovplats < 1)
                    {
                        Console.WriteLine("Något gick fel! Välj 1, 2 eller 3!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-3");
                }
            }
            if (sovplats == 1)
            {
                Sovplats1();
            }
            if (sovplats == 2)
            {
                Sovplats2();
            }
            if (sovplats == 3)
            {
                Sovplats3();
            }
        }
        static void Sovplats1()
        {
            Console.Clear();
            Console.WriteLine("Du håller dig vaken men efter ett tag så känner du hur du måste sova");
            Console.WriteLine("Väljer du att hålla dig vaken eller att lägga dig på en bänk och sova?");
            Console.WriteLine("Alternativ 1 är att hålla dig vaken och alternativ 2 är att sova på bänken!");
            Console.WriteLine();
            int vakenSova;
            while (true)
            {
                try
                {
                    Console.Write("Skriv ditt val här: ");
                    vakenSova = int.Parse(Console.ReadLine());
                    if (vakenSova > 2 || vakenSova < 1)
                    {
                        Console.WriteLine("Något gick fel! Välj 1 eller 2!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-2");
                }
            }
            if (vakenSova == 1)
            {

            }
            else if (vakenSova == 2)
            {
                Sovplats2();
            }
        }
        static void Sovplats2()
        {
            Console.Clear();
            Console.WriteLine("Du hittar ingen bänk eller sovplats så du lägger dig på marken");
            Console.WriteLine("Det var det sista som syntes av dig då ett främmande djur kom och åt upp dig");
            Console.WriteLine("Klicka på \"Enter\" för att komma till slutskärmen");
        }
        static void Sovplats3()
        {
            Console.Clear();
            Console.WriteLine("Det gick bra att sova i kojan och du bestämmer dig för att fortsätta ta en cykel och åka vidare på vägen");
            Console.ReadLine();
            Vinst();
        }
        static void StigValTre()
        {
            Console.Clear();
            Console.WriteLine("Vägen delar upp sig i två, åt ena hållet fortsätter du höra ljud och åt andra hållet är det helt tyst");
            Console.WriteLine("Alternativ 1 är att gå åt det hållet med ljud och alternativ 2 är att gå åt det tysta hållet");
            Console.WriteLine();
            int valAvHåll;
            while (true)
            {
                try
                {
                    Console.Write("Skriv ditt val här: ");
                    valAvHåll = int.Parse(Console.ReadLine());
                    if (valAvHåll > 2 || valAvHåll < 1)
                    {
                        Console.WriteLine("Något gick fel! Välj 1 eller 2!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-2");
                }
            }
            if (valAvHåll == 1)
            {
                Console.WriteLine("Du klarade inte stressen av ljudet som närmade sig, du har förlorat, klicka på \"Enter\" för att komma till slutskärmen");
            }
            if (valAvHåll == 2)
            {
                Console.WriteLine("Du fortsätter på vägen, du kommer till en by, du letar efter personer.");
                Console.WriteLine("Klicka på \"Enter\" för att fortsätta");
                Console.ReadLine();
                Byn();
            }
        }
        static void StigValFyra()
        {
            Console.Clear();
            Console.WriteLine("Du passerar den främmande mannen med en nick som hälsning, vägen går åt vänster och korsar 3 stigar och går in i den tredje stigen");
            Console.WriteLine("Du väljer vilken stig från vänster till höger 1-3.");
            Console.WriteLine();
            int korsandeStigar;
            while (true)
            {
                try
                {
                    Console.Write("Skriv ditt val här: ");
                    korsandeStigar = int.Parse(Console.ReadLine());
                    if (korsandeStigar > 3 || korsandeStigar < 1)
                    {
                        Console.WriteLine("Något gick fel! Välj 1, 2 eller 3!");
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Något gick fel, försök bara mata in 1 siffra inom spannet 1-3");
                }
            }
            if (korsandeStigar == 1)
            {
                StigValEtt();
            }
            else if (korsandeStigar == 2)
            {
                StigValTvå();
            }
            else if (korsandeStigar == 3)
            {
                StigValTre();
            }
        }
        static void Vinst()
        {
            Console.Clear();
            Console.WriteLine("Grattis du vann i spelet och klarade dig!");
            Console.Write("Hur många försök tog det? ");
            int antal = 0;
            try
            {
                antal = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Skriv in en siffra! ");
            }
            if (antal <= 3)
            {
                Console.WriteLine("Wow du lyckades på mindre än 3 försök!");
            }
            else if (antal > 3 || antal <= 5)
            {
                Console.WriteLine(antal + "är ändå ett bra resultat!");
            }
            else
            {
                Console.WriteLine("Det kunde gått bättre, bättre lycka nästa gång!");
            }
        }
        static bool Förlust(bool game = true)
        {
            Console.Clear();
            Console.WriteLine("Tyvärr du har förlorat");
            
            
            while (true)
            {

                Console.Write("Klicka på \"Enter\" för att börja om, ifall du vill avsluta programmet klicka på valfri knapp");
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    game = true;
                    return game;
                }
                else if (Console.ReadKey(true).Key != ConsoleKey.Enter)
                {
                    game = false;
                    return game;
                }
            }
        }
    }
}

