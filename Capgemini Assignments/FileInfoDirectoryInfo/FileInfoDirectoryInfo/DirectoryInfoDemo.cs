using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Directory is a file
//acts as a folder for other files
namespace FileInfoDirectoryInfo
{
    class DirectoryInfoDemo
    {
        //DirectoryInfo class
        //Used to perform operations like
        //Create, Delete, Copy and Move
        //This class can't be inherited
        public void Directory()
        {
            string path1 = "E:\\DirectoryInfo";
            DirectoryInfo dir = new DirectoryInfo(path1);

            //Check if this Directory Exist or not
            if(dir.Exists)
            {
                Console.WriteLine("{0} Directory already exists" , path1);
                Console.WriteLine("Directory Name:" +dir.Name);
                Console.WriteLine("Path:" +dir.FullName);
                Console.WriteLine("Directory Created on:" +dir.CreationTime);
                Console.WriteLine("Directory is last Accessed on:" +dir.LastAccessTime+"\n");
            }
            else
            {
                //Create Directory
                dir.Create();
                Console.WriteLine(path1 , "\t{0} Directory Created successfully"+"\n");
            }

           
           

            //Delete Directory
            Console.WriteLine("If u want to delete directory press y ");
            char c = char.Parse(Console.ReadLine());
            if(c=='y')
            {
                dir.Delete();
                Console.WriteLine(path1 + "Directory deleted successfully");
            }
            else
            {
                Console.WriteLine(path1 + "Directory does Not Exists");
            }
           

        }
    }
}
