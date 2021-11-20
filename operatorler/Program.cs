using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama
            int x = 4;
            int y = 2;
            Console.WriteLine(y);
            y =y+4;
            Console.WriteLine(y);
            y+=3;
            Console.WriteLine(y);
            x=x+2;
            Console.WriteLine(x);
            x-=3;
            Console.WriteLine(x);
            //Mantıksal Operatorler
            //  || && !
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            Console.WriteLine("Ve!");

            if(isSuccess || isCompleted)
            Console.WriteLine("Veya!");

            if(isSuccess && !isCompleted)
            Console.WriteLine("Ve! ve Degili!");

            // İlişkisel Operatorler
            // ==  !=  <  > >= <=
            int a =5;
            int b =2;
            
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            
            //  Aritmatik Operatörler
            //  / * + -
            
            int sayı1 =4;
            int sayı2 =2;
            int sonuc1= sayı1/sayı2;
            Console.WriteLine(sonuc1);
            sonuc1= sayı1*sayı2;
            Console.WriteLine(sonuc1);
            sonuc1= sayı1+sayı2;
            Console.WriteLine(sonuc1);
            sonuc1= sayı1-sayı2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayı1++;
            Console.WriteLine(sonuc1);



            // % : mod alır
            int sonuc2 =19%3;
            Console.WriteLine(sonuc2);


        }
    }
}
