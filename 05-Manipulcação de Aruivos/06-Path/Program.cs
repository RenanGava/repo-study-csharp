using System.Collections.Generic;


namespace Course
{

    class Program
    {

        static void Main()
        {
            string path = @"C:\Users\renan\Desktop\C#\05-Manipulcação de Aruivos\06-Path\txt1.txt";
            Console.WriteLine("DirectorySeparatorChar:" + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: "+ Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));

            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            
        }
    }
}