using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.IO;

namespace czytanie_z_pliku
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "data.txt";
        
            String[] items = File.ReadAllText(path).Split(new String[] { ";", Environment.NewLine },StringSplitOptions.RemoveEmptyEntries); 
            // rozdziela stringa, np jak mam ciąg 1;2;3;4 to rozdzieli mi elementy, pierwszy paramentr przyjmuje mi rzecz którą ma mi rozpoznać kiedy kończy się element 
           
            List<int> numbers = new List<int>();
            foreach (String item in items)
            {
                int value = 0;
                if (Int32.TryParse(item.Trim(), out value)) // trim, usuwa białe znaki, spacje na początku i na końcu stringa
                {
                    numbers.Add(value);
                }
                else
                {
                    Console.WriteLine("Wartosc '" + items + "' nie jest liczba!");
                }
            }
            Console.WriteLine("Plik zawiera takie liczby:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
