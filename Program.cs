using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_conversie
{
    class Program
    {
        static void Main(string[] args)
        {
            int rest;
            string result = "";
            double result10 = 0;
            Stack<int> stiva = new Stack<int>();

            Console.WriteLine("Ce numar doriti sa convertiti?");
            int numar = int.Parse(Console.ReadLine());

            double baza_tinta, baza;

            do
            {
                Console.WriteLine("In ce baza este numarul? (intre 2 si 16)");
                baza = double.Parse(Console.ReadLine());

            } while (baza<2 || baza>16);


            do
            {
                Console.WriteLine("In ce baza doriti sa convertiti numarul? (intre 2 si 16)");
                baza_tinta = int.Parse(Console.ReadLine());

            } while (baza_tinta < 2 || baza_tinta > 16);


            

            if (baza != 10)
            {
                // aici convertim din baza 8 in baza 10

                double i = 0;
                do
                {
                    
                    result10 = result10 + ((numar % 10) * Math.Pow(baza, i));
                    numar = numar / 10;
                    i++;

                } while (numar!=0);

                Console.WriteLine(result10);


                // si apoi din baza 10 in baza care o vrem

                do
                {
                    rest = (int)result10 % (int)baza_tinta;
                    result10 = result10 / baza_tinta;
                    stiva.Push((int)rest);

                } while (result10 != 0);
                
                while (stiva.Count > 0)
                {
                    result = result + stiva.Pop().ToString();
                }

                Console.WriteLine(result);




            }
            else //aici baza este 10
            {
                do
                {
                    rest = (int)numar % (int)baza_tinta;
                    numar = numar / (int) baza_tinta;
                    stiva.Push(rest);

                } while (numar!=0);

                while (stiva.Count > 0)
                {
                    result = result + stiva.Pop().ToString();
                }

                Console.WriteLine(result);
            }

            
            


        }
    }
}
