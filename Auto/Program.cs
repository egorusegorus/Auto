using System.Xml.Linq;

namespace Auto
{
    class Auto
    {
        public double Beschleunigung;
        public string Bezeichnung;
        public string Hersteller;
        public int Höchstegeschwindigket;
        public double Kw;

        public double Ps()
        {
            double ps = 0.74 * Kw;
            return ps;
        }

       public Auto(double Beschleunigung1, string Bezeichnung1, string Hersteller1, int Höchstegeschwindigket1, double Kw1)
        {
            Beschleunigung = Beschleunigung1;
            Bezeichnung = Bezeichnung1;
            Hersteller = Hersteller1;
            Höchstegeschwindigket = Höchstegeschwindigket1;
            Kw = Kw1;
            double PS = Ps();
        }

        public override string ToString()
        {
            string str = "";
            str += "\nBeschleunigung: " + Beschleunigung;
            str += "\nBezeichnung: " + Bezeichnung;
            str += "\nHersteller: " + Hersteller;
            str += "\nHöchstegeschwindigkeit: " + Höchstegeschwindigket;
            str += "\nKw: " + Kw;
            str += "\nPS: " + Ps();

            return str;
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();    
                Console.WriteLine("Auto");
                
                Auto auto1 = new Auto(6.2, "Golf", "Volkswagen", 180, 180);
                Auto auto2 = new Auto(4.2, "M3", "BMW", 353, 300);
                Auto auto3 = new Auto(7.3, "A4 2.0 TFSI", "Audi", 140, 200);
                Console.WriteLine(auto1);
                Console.WriteLine(auto2);
                Console.WriteLine(auto3);
                Console.ReadLine();
            }
        }
    
}
