﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AirportParser
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Infinite Flight Airports");
                Console.WriteLine("Copyright 2015, Flying Development Studios. and respective content owners.\n");

                //define functions
                Console.WriteLine("Available functions:");
                Console.WriteLine("1 - AptDivider");
                Console.WriteLine("2 - ParkingSort");
                Console.WriteLine("3 - BoundaryCreator");
                Console.WriteLine("\nEnter the number for the function you wish to run.");


            while (true) // Loop indefinitely 
            {
                //headers

                string input = Console.ReadLine(); // input
                if (input == "1")
                {
                    //selected AptDivider
                    Console.WriteLine("Running AptDivider...\n");

                    //check if file exists at base directory
                    if (File.Exists(AptDivider.BasePath))
                    {
                        AptDivider.AptDividerFunction();

                    } else {

                        Console.WriteLine("Error: Can't find directory at path: " + AptDivider.BasePath);
                        Console.WriteLine("Adjust BasePath variable to directory containing apt.mdat in root.");
                        Console.WriteLine("Ending program...");
                        Console.ReadKey();

                    }
                    

                } else if (input == "2")
                {
                    //selected ParkingSort
                    Console.WriteLine("Running ParkingSort...");

                    ParkingSort.MainBlock();

                } else if (input == "3")
                {
                    //selected BoundaryCreator
                    Console.WriteLine("Running BoundaryCreator...");
                    BoundaryCreator.CreateBoundary();
                    

                }
               

            }

        }
    }
}
