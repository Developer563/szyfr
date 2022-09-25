using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szagicrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Lang();
            



        }

        static void Lang()
        {

            string key;
            
            Console.WriteLine("select launglage / wybierz język:");

            Console.WriteLine("1 - pl");

            Console.WriteLine("2 - eng");

            key = Console.ReadLine();

            if (key == "1")
            {
                
                Decrypt("8","5",8);

            }
            else 
            {
                if (key == "2")
                {






                }
                else
                {

                    Console.WriteLine("error");

                    Console.ReadKey();
                
                
                }
                

            }
            
        }









        static void Encrypt(string[] enc, string[] key, int[] pim)
        {





            

        }

        static void Decrypt(string enc, string key, int pim)
        {
            






        }






    }
}
