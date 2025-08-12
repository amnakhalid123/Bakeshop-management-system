using ConsoleProject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opt = ProductUI.MainMenu();
                Console.Clear();

                if (opt == "1")
                {
                    Console.WriteLine(ProductUI.ViewProducts());
                }
                else if (opt == "2")
                {
                    Console.WriteLine(ProductUI.AddProduct());
                }
                else if (opt == "3")
                {
                    Console.WriteLine(ProductUI.DeleteProduct());
                }
                else if (opt == "4")
                {
                    Console.WriteLine(ProductUI.UpdatePrice());
                }
                else if (opt == "5")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Wrong Option!!!");
                }
                Console.WriteLine("\nPress Any Key to Continue..");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
