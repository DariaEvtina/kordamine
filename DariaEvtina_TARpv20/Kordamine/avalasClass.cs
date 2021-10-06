using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class avalasClass
    {
        public static void Main(string[] args)
        {
            // esemene ülesane
            Console.WriteLine("Tere Tulemast!");
            Console.WriteLine("Kirjuta esemene eesnimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Kirjuta teine eesnimi: ");
            string eesnimi2 = Console.ReadLine();
            if (eesnimi.ToLower()=="tantomile" && eesnimi2.ToLower() == "coricopat")
            {
                Console.WriteLine("Tana ta on pinginabrid");
            }
            else if (eesnimi.ToLower() == "danil" && eesnimi2.ToLower() == "erik")
            {
                Console.WriteLine("Tana ta on pinginabrid");
            }
            else
            {
                Console.WriteLine("Tana ta ei ole pinginabrid");
            }
            //teine ülesane
            Console.WriteLine("sisestage seina esimene pikkus(metris): ");
            float a = Math.Abs(float.Parse(Console.ReadLine()));
            Console.WriteLine("sisestage seina teine pikkus(metris): ");
            float b = Math.Abs(float.Parse(Console.ReadLine()));
            Console.WriteLine("seina a= {0} ja seina b= {1} teie klassi korrus on  {2}", a, b, a * b);
            Console.WriteLine("Kas tahat remondi teha");
            string vastus = Console.ReadLine();
            if (vastus.ToLower()=="jah")
            {
                Console.Write("Kui suur ruut metri hind?");
                float ruutHind = Math.Abs(float.Parse(Console.ReadLine()));
                Console.Write("{0} - {1} eurot",a*b,Math.Round((a * b)*ruutHind),2);
            }
            else
            {
                Console.Write("head aega");
            }



            //kolmas ülesane
            Console.WriteLine("sisestage hinna: ");
            float hind = Math.Abs(float.Parse(Console.ReadLine()));
            Console.WriteLine(" {0} - 30% on {1}", hind, hind-((hind * 30)/100));
            //neljas ülesane
            Console.WriteLine("Sisetage oma klassi temperatuur(C': ");
            int temperatur = int.Parse(Console.ReadLine());
            if (temperatur>=18 && temperatur<=22)
            {
                Console.WriteLine("teie temperatuur vastab talvel soovitud toatemperatuurile");
            }
            else
            {
                Console.WriteLine("teie temperatuur ei vastab talvel soovitud toatemperatuurile");
            }
            //viies ülesane
            Console.WriteLine("Sisetage oma pikkus(sm): ");
            int pikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Sisetage oma sugu: ");
            string sugu = Console.ReadLine();
            if (pikkus>=110 && pikkus<=155 && sugu == "naise")
            {
                    Console.WriteLine("sa oled lühike kasva");
            }
            else if (pikkus >= 156 && pikkus <= 175 && sugu == "naise")
            {
                Console.WriteLine("sa oled keskmine kasva");
            }
            else if (pikkus >= 176 && pikkus <= 209 && sugu == "naise")
            {
                Console.WriteLine("sa oled pikku kasva");
            }
            else if (pikkus < 0 || pikkus >= 210 && sugu == "naise")
            {
                Console.WriteLine("prof?");
            }
            if (pikkus >= 120 && pikkus <= 165 && sugu == "mees")
            {
                Console.WriteLine("sa oled lühike kasva");
            }
            else if (pikkus >= 166 && pikkus <= 179 && sugu == "mees")
            {
                Console.WriteLine("sa oled keskmine kasva");
            }
            else if (pikkus >= 180 && pikkus <= 210 && sugu == "mees")
            {
                Console.WriteLine("sa oled pikku kasva");
            }
            else if (pikkus < 0 || pikkus >= 211 && sugu == "mees")
            {
                Console.WriteLine("prof?");
            }
            //kuues ülesane

            Console.WriteLine("Tere, kas sa tahad osta  piima (0.50 eurot)?");
            string piim = Console.ReadLine();
            Console.WriteLine("Tere, kas sa tahad osta  saja (1.00 eurot)?");
            string saja = Console.ReadLine();
            Console.WriteLine("Tere, kas sa tahad osta  leiva (0.99 eurot)?");
            string leiva = Console.ReadLine();
            if (piim=="jah" && saja=="jah" && leiva=="jah")
            {
                Console.WriteLine("teie kogusumma:{0}",0.50+1.00+0.99);
            }
            else if (piim == "jah" && saja == "jah" && leiva == "ei")
            {
                Console.WriteLine("teie kogusumma:{0}", 0.50 + 1.00 );
            }
            else if (piim == "jah" && saja == "ei" && leiva == "jah")
            {
                Console.WriteLine("teie kogusumma:{0}", 0.50 + 0.99);
            }
            else if (piim == "ei" && saja == "jah" && leiva == "jah")
            {
                Console.WriteLine("teie kogusumma:{0}", 1.00 + 0.99);
            }
            else if (piim == "ei" && saja == "ei" && leiva == "jah")
            {
                Console.WriteLine("teie kogusumma:{0}", 0.99);
            }
            else if (piim == "ei" && saja == "jah" && leiva == "ei")
            {
                Console.WriteLine("teie kogusumma:{0}", 1.00);
            }
            else if (piim == "jah" && saja == "ei" && leiva == "ei")
            {
                Console.WriteLine("teie kogusumma:{0}", 0.50);
            }
            else
            {
                Console.Write("head aega");
            }
            //valik
            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule minu juurde külla {0}!", eesnimi);
                Console.WriteLine("me plaanisime kinno minna,kui vana ta on?");
                int vanus = int.Parse(Console.ReadLine());
                if (vanus < 0 || vanus >= 120)
                {
                    Console.WriteLine("Viga andmetega!");
                }
                else if (vanus < 6)
                {
                    Console.WriteLine("Ta lähmes filmis tasuta " + eesnimi);
                }
                else if (vanus >= 6 && vanus <= 14)
                {
                    Console.WriteLine("Ta pead ostma lastepiled " + eesnimi);
                }
                else if (vanus >= 15)
                {
                    Console.WriteLine("Ta pead ostma taispiled " + eesnimi);
                }
                else if (vanus >= 65)
                {
                    Console.WriteLine("Ta pead ostma soodupiled " + eesnimi);
                }
            }
            else
            {
                Console.WriteLine("Külalised ei oota, {0}", eesnimi);
            }
            Console.WriteLine("Kirjuta esemene arv:");
            //int arv1 = Convert.ToInt32(Console.ReadLine());
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjuta teine arv:");
            //int arv2 = Convert.ToInt32(Console.ReadLine());
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);


            Console.ReadLine();

        }

        
    }
}
