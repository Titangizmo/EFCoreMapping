﻿using System;
using System.Reflection;
using Model.Entities;
using Model.Repositories;


namespace UI
{
    class Program
    {
        //private static readonly EFOpleidingenContext context = new EFOpleidingenContext();
        static void Main(string[] args)
        {
            string keuze = string.Empty;
            while (keuze.ToUpper() != "X")
            {
                //Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("----");
                Console.WriteLine("Menu");
                Console.WriteLine("----");
                Console.WriteLine(" 1. Owned Types / Complex Types");


                Console.Write("Keuze ('X' om te stoppen): ");
                keuze = Console.ReadLine();
                Console.WriteLine("----------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                if (keuze.ToUpper() != "X")
                {
                    // Reflection
                    Program p = new Program();
                    Type t = p.GetType();
                    try
                    {
                        MethodInfo mi = t.GetMethod("Item" + "00".Substring(0, -
                        keuze.Length + 2) + keuze, BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                        mi.Invoke(p, null);
                        //string result = mi.Invoke(p, new object[] { par1, par2}).ToString();
                    }
                    catch
                    {
                        Console.WriteLine("Ongeldige keuze");
                    }
                }

                // ===
                // End
                // ===
                if (keuze.ToUpper() == "X") break;
                Console.WriteLine("\nDruk een toets");
                Console.ReadKey();
                Console.Clear();
            }
        }
        // ---------
        // Menu-item
        // ---------
        static void Item01()
        {
            using var context = new EFCoreMappingContext();
            var campus = new Campus
            {
                Naam = "VDAB Wondelgem",
                Adres = new Adres
                {
                    Straat = "Industrieweg",
                    Huisnummer = "50",
                    Postcode = "9032",
                    Gemeente = "Gent"
                }
            };
            var johan = new Docent
            {
                Voornaam = "Johan",
                Familienaam = "Vandaele",
                Wedde = 1000m,
                InDienst = new DateTime(2016, 2, 1),
                HeeftRijbewijs = true,
                AdresThuis = new Adres
                {
                    Straat = "Ter Lake",
                    Huisnummer = "7",
                    Postcode = "8310",
                    Gemeente = "Brugge"
                },
                AdresWerk = new Adres
                {
                    Straat = "Hertsbergsestraat",
                    Huisnummer = "91",
                    Postcode = "8020",
                    Gemeente = "Oostkamp"
                },
                Campus = campus
            };
            context.Add(johan);
            context.SaveChanges();
        }
    }
}

