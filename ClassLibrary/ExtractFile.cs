﻿using System;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class globalVar
    {

        //public static string searchFolder = @"C:\test\completed";
        public static string searchFolder = @"Z:\SeagateDisk\MediaFolder\completed";
        //public static string destinationFolder = @"C:\test\destination";
        public static string destinationFolder = @"Z:\2TBdisk\temp"; 

    }
    public class ExtractFile
    {
        public string fileName { get; set; }
        public string filePath { get; set; }
        public string fileDestination { get; set; }
    }

    public class Destination
    {
        public string FinalFolder(string fileName)
        {
            var finalFolder = "";
            if (fileName.Contains("test"))
            {
                Console.WriteLine("file is a tvShow");
                //TODO: determine showname and designated folder.
                //TODO: run checkFolder to make sure folder exists.
                 finalFolder = globalVar.destinationFolder + @"\tvShow";
                return finalFolder;
            }
            else
            {
                Console.WriteLine("file is a movie");
                finalFolder = globalVar.destinationFolder + @"\movie";
                return finalFolder;
            }
            Console.WriteLine(finalFolder);
            return finalFolder;
        }
        public static string CheckFolder(string fileName)
        {
            var checkFolder = "";
            //TODO: check if designated folder exists, if not, create it.
            return checkFolder;
        }

    }
}
