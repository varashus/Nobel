using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nobel
{
    class Program
    {
        
            static void Main(string[] args)
            {
                var emberek = new List<Dij>();
                using var sr = new StreamReader(
                    path: @"..\..\..\scr\orvosi_nobeldijak.txt",
                    encoding: System.Text.Encoding.UTF8
                );
                _ = sr.ReadLine();
                while (!sr.EndOfStream) emberek.Add(new(sr.ReadLine()));


            Console.WriteLine($"3.feladat: {emberek.Count} fő");
            int max = emberek.Max(n => n.ev);
            Console.WriteLine($"4.feladat: {max} ");




            Console.WriteLine("add mega az ember nemzetiseget: ");
            string ok = Console.ReadLine();
            var f5 = emberek.Where(d => d.orszkod == ok).ToList();
            if (f5.Count == 0)
            {
                Console.WriteLine("nem volt");
            }
            else if(f5.Count == 1)
            {
                Console.WriteLine($"{f5[0].nev}");
                Console.WriteLine($"{f5[0].ev}");
                Console.WriteLine($"{f5[0].SzH}");
                
            }
            
            


            Console.WriteLine($"6.feladat:");
            



            Console.ReadLine();
            }
            
    }
}
