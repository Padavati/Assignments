using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//File is a static class and it is a collection of data
//That is stored on disk
namespace FileInfoDirectoryInfo
{
    class FileInfoDemo
    {
        //FileInfo class
        //Used to peform operations like
        //Create, Open, Read/Write, Delete
        public void File()
        {
            string path = "E:\\FileInfo.txt";
            FileInfo file = new FileInfo(path);

            //Creating File
            using (StreamWriter sw = file.CreateText()) 
            sw.WriteLine("Hello FileInfo");

            //check if file exist or not
            if (file.Exists)
            {
                //Display File Info
                Console.WriteLine("File Created On :" + file.CreationTime);
                Console.WriteLine("Directory Name :" + file.DirectoryName);
                Console.WriteLine("Full Name of File :" + file.FullName);
                Console.WriteLine("File is last Accessed on :" + file.LastAccessTime + "\n");
            }
            else
            {
                file.Create();
                Console.WriteLine("File Created Successfully");
            }

            //Deleting File
            Console.WriteLine("Press small y to delete this file");
            char c = char.Parse(Console.ReadLine());
            if (c == 'y')
            {
                  file.Delete();
                  Console.WriteLine(path + "\tDeleted Successfully");
            }
            else
            {
                  Console.WriteLine("File does not exist");
            } 
        }
    }
}
