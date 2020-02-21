using System;
using System.IO;

namespace FDB
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBinary();
            ReadBinary();
        }

        public static void WriteBinary()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open(@"C:\Users\bptnbs\Downloads\sample.bin", FileMode.Create)))
            {
                //Writing Error Log
                bw.Write("0x80234400");
                bw.Write("MAD has stopped working");
                bw.Write(true);
            }
        }

        public static void ReadBinary()
        {
            using (BinaryReader br = new BinaryReader(File.Open(@"C:\Users\bptnbs\Downloads\sample.bin", FileMode.Open)))
            {
                Console.WriteLine("Error Code: " + br.ReadString());
                Console.WriteLine("Message: " + br.ReadString());
                Console.WriteLine("Restart Program: " + br.ReadBoolean());
            }
        }

        public static void Example1()
        {
            DirectoryInfo di = new DirectoryInfo(@"c:\MyDir");
            try
            {
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    // Indicate that the directory already exists.
                    Console.WriteLine("That path exists already.");

                    di.Delete();
                    Console.WriteLine("Not anymore, dude!");
                    return;
                }

                // Try to create the directory.
                di.Create();
                Console.WriteLine("The directory was created successfully.");

                // Delete the directory.
                // di.Delete();
                // Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }

        public static void Example2()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\bptnbs\Downloads");
            Console.WriteLine("No search pattern returns:");
            if (di.Exists)
            {
                foreach (var fi in di.EnumerateFiles())
                {
                    Console.WriteLine(fi.Name);
                }

                Console.WriteLine();

                Console.WriteLine("Search pattern *2* returns:");
                foreach (var fi in di.EnumerateFiles("*2*"))
                {
                    Console.WriteLine(fi.Name);
                }

                Console.WriteLine();

                Console.WriteLine("Search pattern test?.txt returns:");
                foreach (var fi in di.EnumerateFiles("test?.txt"))
                {
                    Console.WriteLine(fi.Name);
                }

                Console.WriteLine();

                //Console.WriteLine("Search pattern AllDirectories returns:");
                //foreach (var fi in di.EnumerateFiles("*", SearchOption.AllDirectories))
                //{
                //    Console.WriteLine(fi.Name);
                //}
            }
            else
                Console.WriteLine("Directory does not exist");
        }
    }
}
