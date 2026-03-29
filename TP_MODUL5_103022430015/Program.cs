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

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();

            string namaPraktikan = "Nama";

            halo.SapaUser(namaPraktikan);
        }
    }
}