﻿using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Names = { "Rick Sanchez", "Morty Smith", "Jerry Smith", "Beth Smith", "Summer Smith" };
            string[] Phone = { "555-1334", "555-3882", "555-8211", "555-1617", "555-2803" };
            string strSearch;

            //prompt user
            Console.WriteLine("Type a name to search for in the phone book:");
            strSearch = Console.ReadLine();

            for(int n = 0; n < Names.Length; n++)
            {
                if (Names[n].IndexOf(strSearch) > -1)
                {
                    Console.WriteLine(Names[n] + " -> " + Phone[n]);
                }
            }

        }
    }
}
