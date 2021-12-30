using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInfoDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo 
            //FileInfoDemo fs = new FileInfoDemo();
            //fs.File();

            //DirectoryInfo
            DirectoryInfoDemo dr = new DirectoryInfoDemo();
            dr.Directory();

            Console.ReadKey();
        }
    }
}
