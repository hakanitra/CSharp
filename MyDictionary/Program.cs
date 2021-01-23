using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Hakan");

            Console.WriteLine(isimler.Length);

            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);



            foreach (var eleman in isimler.Elemanlar)
            {
                Console.WriteLine(eleman);
            }
        }
    }
}
