using System;
using System.Collections.Generic;
using TimothyHsu_Kort_List.Interfaces;
using TimothyHsu_Kort_List.Models;

namespace TimothyHsu_Kort_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> products = new List<IProduct>();
            products.Add(new Product() 
            {
                Merk = "Cola",
                Naam = "Zero",
                Volume = "150 ml"
            });
            products.Add(new Product()
            {
                Merk = "Fanta",
                Naam = "Lemon",
                Volume = "1000 ml"
            });
            products.Add(new Product()
            {
                Merk = "Soda",
                Naam = "Gas",
                Volume = "150 ml"
            });
            foreach (var item in products)
            {
                Console.WriteLine(item.GetCode());
            }
        }
    }
}
