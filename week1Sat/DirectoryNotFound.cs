using System;
using System.IO;
namespace week1Sat
{
    class DirectoryNotFound
    {
        public DirectoryNotFound()
        {
            try
            {
                string dir = @"C:\Users\sonp";
                // If this directory does not exist, a DirectoryNotFoundException is thrown
                // when attempting to set the current directory.
                Console.WriteLine("before exception ");
                Directory.SetCurrentDirectory(dir);
                Console.WriteLine("after exception ");
            }
            catch (DirectoryNotFoundException dirEx)
            {
                Console.WriteLine("Directory not found: " + dirEx.Message);
            }
        }
    }
}
