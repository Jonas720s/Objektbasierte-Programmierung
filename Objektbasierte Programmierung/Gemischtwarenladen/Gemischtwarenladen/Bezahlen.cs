using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemischtwarenladen
{
    public class Bezahlen
    {
        private double gesammtpreis;
        private bool zahlungsart = true;
        private string entscheid;
        public Bezahlen(double Gesammtpreis) 
        { 
            this.gesammtpreis = Gesammtpreis;
        }
        
        public string Zahlungsart()
        {
            string cgesammtpreis = string.Format("{0:C2}", gesammtpreis);
            Console.WriteLine($"Mit Welchem Zahlungsmittel möchten sie den Gesammtbetrag von {cgesammtpreis} bezahlen?\nKarte\nTWINT\nBar");
            while (zahlungsart)
            {
                string szahlungsart = Console.ReadLine();
                if ( szahlungsart.ToUpper() == "KARTE" )
                {
                    Console.WriteLine($"Sie bezahlen den Betrag {cgesammtpreis} mit Karte, bitte beachten sie die Anzeige auf dem Terminal");
                    entscheid = "K";
                    zahlungsart = false;
                    break;
                }
                else if (szahlungsart.ToUpper() == "TWINT")
                {
                    Console.WriteLine($"Sie bezahlen den Betrag {cgesammtpreis} mit TWINT, bitte scannen sie den QR-Code");
                    entscheid = "T";
                    zahlungsart = false;
                    break;
                }
                else if (szahlungsart.ToUpper() == "BAR")
                {
                    Console.WriteLine($"Sie bezahlen den Betrag {cgesammtpreis} bar");
                    entscheid = "B";
                    zahlungsart = false;
                    break;
                }
                else 
                { 
                    Console.WriteLine("Diesen Befehl gibt es nicht!");
                    entscheid = "W";
                    break;
                }
            }
            return entscheid;
            
            
        }
        public double KartenZahlung()
        {
            Console.Write("Wie viel Geld wurde von der Karte abgebucht?");
            string abgebuchtk = Console.ReadLine();
            double dabfebuchtk = Double.Parse(abgebuchtk);
            gesammtpreis = gesammtpreis - dabfebuchtk;
            return gesammtpreis;
        }
        public double TwintZahlung()
        {
            Console.Write("Wie viel Geld wurde mit TWINT bezahlt?");
            string abgebuchtt = Console.ReadLine();
            double dabfebuchtt = Double.Parse(abgebuchtt);
            gesammtpreis = gesammtpreis - dabfebuchtt;
            return gesammtpreis;
        }
        public double BarZahlung()
        {
            Console.Write("Wie viel Geld wurde Bar bezahlt?");
            string abgebuchtb = Console.ReadLine();
            double dabfebuchtb = Double.Parse(abgebuchtb);
            gesammtpreis = gesammtpreis - dabfebuchtb;
            return gesammtpreis;
        }
    }

}
