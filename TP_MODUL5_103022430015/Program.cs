using System;

namespace ModulPraktikan
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T input)
        {
            Console.WriteLine($"Halo user {input}");
        }
    }

    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            string namaPraktikan = "Nama";
            halo.SapaUser(namaPraktikan);

            DataGeneric<string> nimObj = new DataGeneric<string>("103022430015");
            nimObj.PrintData();
        }
    }
}