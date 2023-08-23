using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wutparameter
{
    internal class Person
    {

        private int wutLevel = 0;
        private int appetitLevel = 0;

        public void Provozieren(int provokationsLevel)
        {
            wutLevel += provokationsLevel;
            if (wutLevel > 9)
            {
                Ausrasten();
            }
            else
            {
                Console.WriteLine($"Ich bin wütend auf level {wutLevel} von 10");
            }
        }


        public void Ausrasten()
        {
            Console.WriteLine($"Ich raste aus!! \n Mein Wutlevel ist auf {wutLevel} von 10");
        }
        public string EssenGeben(string eg)
        {
            

            if (eg == "yes")
            {
                wutLevel = 0;
                appetitLevel = 0;
                Console.WriteLine($"Ich habe mich beruhigt \n Mein Wutlevel ist auf {wutLevel} von 10");
            }
            else { }
            
        }
        /*public void EssenVerweigern()
        {
            wutLevel += 2;
            appetitLevel += 5;
            Console.WriteLine("Ich will jetzt etwas essen!");
            if (wutLevel > 9)
            {
                Ausrasten();
            }
            else
            {
                Console.WriteLine($"Ich bin wütend auf level {wutLevel} von 10 und hungrig!");
            }
        }*/
        public void ArbeitsauftragGeben(int arbeitsLevel)
        {
            wutLevel = arbeitsLevel + wutLevel;
            if(wutLevel > 9)
            {
                Ausrasten();
            }
            else if(wutLevel > 5)
            {
                Console.WriteLine("Ich habe keine Zeit!");
            }
            else { Console.WriteLine("Danke!"); }
        }


    }

}
