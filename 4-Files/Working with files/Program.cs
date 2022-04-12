using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_files
{
    class Program
    {
        static void Main(string[] args)
        {
            CountLines();
        }


        #region 1-Create File
        static void CreateFile(string path)
        {
            File.Create(path);
        }
        static void CreateFile()
        {
            Console.WriteLine("Please enter path of the file");
            File.Create(@Console.ReadLine());
        }
        #endregion
        #region 2-Copy File
        static void CopyFile()
        {
            Console.WriteLine("Please enter the path of the source file");
            string source = @Console.ReadLine();
            Console.WriteLine("Please enter the new path");
            string newpath = @Console.ReadLine();
            File.Copy(source, newpath);
        }
        static void CopyFile(string source,string newpath,bool overwrite)
        {
           
            FileInfo fi = new FileInfo(source);
            fi.CopyTo(newpath, overwrite);

        }
        #endregion
        #region 3-Add text
        static void AddText()
        {
            Console.WriteLine("Please enter path of the file");
            string path = @Console.ReadLine();
            Console.WriteLine("Enter text you want to add");
            string contents = Console.ReadLine();
            File.WriteAllText(path, contents);
            

        }

        #endregion
        #region 4-Read text
        static void ReadText()
        {
            Console.WriteLine("Please enter tha path of the file");
            string path = @Console.ReadLine();
            Console.WriteLine("Please enter text to add");
            string contents = Console.ReadLine();
            File.WriteAllText(path, contents);
            Console.WriteLine(File.ReadAllText(path));
        }

        #endregion
        #region 5-Count Lines
        static void CountLines()
        {
            Console.WriteLine("Please enter the path of the file");
            string path = @Console.ReadLine();
            int Lines = File.ReadAllLines(path).Count();
            Console.WriteLine(Lines);
        }
        #endregion


    }


}
