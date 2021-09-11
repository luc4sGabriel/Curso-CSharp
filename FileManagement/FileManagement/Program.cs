using System;
using System.IO;

namespace FileManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            //Primeira parte sobre manipulacao de arquivos

            /*
            string sourcePath = @"c:\Users\DMess\Documents\helloworld.txt";
            string targetPath = @"c:\Users\DMess\Documents\helloworld2.txt";

            try
            {
                //FileInfo fileInfo = new FileInfo(sourcePath);
                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            //Segunda parte sobre manipulacao de arquivos

            /*string path = @"c:\Users\DMess\Documents\helloworld.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) 
                    sr.Close();
            }
            */

            // Terceira parte sobre manipulacao de arquivos
            /*
             * 
            string path = @"c:\Users\DMess\Documents\helloworld.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            //Quarta parte sobre manipulacao de arquivos
            /*
            string path = @"c:\Users\DMess\Documents\helloworld.txt";
            string targetPath = @"c:\Users\DMess\Documents\helloworld2.txt";

            try
            {
                string[] lines = File.ReadAllLines(path);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */


            //Quinta parte sobre manipulacao de arquivos
            /*
             * string path = @"c:\Users\DMess\Documents\testfolder";

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("-----------------");
                Console.WriteLine("FILES:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */

            string path = @"c:\Users\DMess\Documents\testfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
