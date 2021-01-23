using System;
using System.Collections.Generic;

namespace koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "berkay", "yusuf", "emir", "batuhan" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5];
            isimler[4] = "emir";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]); // bu kısımda olan Berkay Yazmadı
                                           // hatayı alt kısımda yeni bir şekilde derledik

            List<string> isimler2 = new List<string> { "berkay", "emir", "yusuf", "batuhan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("emir");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
