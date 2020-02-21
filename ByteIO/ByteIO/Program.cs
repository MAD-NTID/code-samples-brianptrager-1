using System;
using System.IO;

namespace ByteIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "data.dat";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            int[] numbers = { 10, 20, 30, 40, 50 };

            using(BinaryWriter bw = new BinaryWriter(stream))
            {
                foreach(int n in numbers)
                {
                    bw.Write(n);
                }
                bw.Close();
            }
            stream.Close();

            using(BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                while(br.PeekChar() != -1)
                {
                    Console.WriteLine(br.ReadInt32());
                }
            }
        }
    }
}
