using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _33_of_47_____DRILL
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\mrdav\Desktop\First Folder";
            string targetPath = @"C:\Users\mrdav\Desktop\Second Folder";
            string [] listFiles = Directory.GetFiles(sourcePath, "*.txt");

            foreach (string name in listFiles)
            {
                DateTime modTimeofFile = File.GetLastWriteTime(name);
                DateTime currentTime = DateTime.Now;
                string sourceFile = System.IO.Path.Combine(sourcePath, name);
                string variable = Path.GetFileName(name);
                string destFile = System.IO.Path.Combine(targetPath, variable);
          

                if ((currentTime.Day - modTimeofFile.Day) <= 1)
                {
                    File.Copy(sourceFile, destFile, true);
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
