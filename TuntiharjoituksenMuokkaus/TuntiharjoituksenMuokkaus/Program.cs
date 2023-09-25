using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TuntiharjoituksenMuokkaus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Nimilista = new List<string>();
            string nimi = "";
            Console.WriteLine("Anna henkilön nimi tai x lopettaaksesi.");
            while (nimi.ToUpper() != "X")
            {
                Console.Write("Anna nimi: ");
                nimi = Console.ReadLine();
                if (nimi.ToUpper() != "X")
                {
                    Nimilista.Add(nimi);
                }
            }
            bool virhe = true;
            while (virhe)
            {
                virhe = false;
                Console.WriteLine("Haluatko lajitella nimet A = nousevassa järjestyksessä, vai B = laskevassa järjestyksessä.");
                string valinta = Console.ReadLine().ToUpper();
                try
                {
                    switch (valinta)
                    {
                        case "A":
                            Nimilista.Sort();//Lajittelee nousevaan järjestykseen
                            break;
                        case "B":
                            Nimilista.Sort();
                            Nimilista.Reverse();//Käänteiseen
                            break;
                        default:
                            throw new Exception("Virheellinen valinta!");

                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.Message);
                    Console.WriteLine("Yritä uudelleen.");
                    virhe = true;
                }
                    if (!virhe)
                    {
                        for (int i = 0; i < Nimilista.Count; i++)//tulostaa listan sisällön 
                        {
                            Console.WriteLine("Listan alkio " + i + " on " + Nimilista[i]);
                        }
                    }
            }      
            Console.ReadLine();
        }
    
    }
}
