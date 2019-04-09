using System;

namespace Selection_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("menggunakan type data");
            Variabel();
            Console.WriteLine("====================");
            Console.WriteLine("Menggunakan kompiler");
            VAR();
            Console.WriteLine("====================");
            Console.WriteLine("Konstanta Min dan Max");
            KonstantaMinMax();
            Console.WriteLine("====================");
            Console.WriteLine("Type data const");
            KonstantaConst();
            Console.WriteLine("====================");
            Console.WriteLine("Type Conversion Versi 1");
            TypeConversionVer1();
            Console.WriteLine("====================");
            Console.WriteLine("Type Conversion Versi 2");
            TypeConversionVer2();
            Console.WriteLine("====================");
            Console.WriteLine("Type Conversion Versi 3");
            TypeConversionVer3();
            Console.WriteLine("====================");
            Console.WriteLine("Operator");
            Operator();
            Console.ReadLine();
            Console.ReadKey();
        }

        public static void Variabel()
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Jody";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }

        public static void VAR()
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Jody";
            var isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }

        public static void KonstantaMinMax()
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }

        public static void KonstantaConst()
        {
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            // bilangan konstanta tidak bisa dirubah oleh karena itu dikomen, jika penasaran silahkan unkomen dan lihat errornya
             // Pi = 1;
        }

        public static void TypeConversionVer1()
        {
            // rekap byte ke integer ver 1
            //byte b = 1;
            //int i = b;
            // Console.WriteLine(i);

            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);
        }

        public static void TypeConversionVer2()
        {
            // konversi string ke integer
            //var number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);


            // konversi string ke byte
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The Number could not be converted");
            }
        }

        public static void TypeConversionVer3()
        {
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch(Exception)
            {
                Console.WriteLine("The Number could not be converted");
            }
        }

        public static void Operator()
        {
            var a = 10;
            var b = 2;
            var c = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine((float)a /(float)b);
            Console.WriteLine(a + b * c);
            Console.WriteLine((a + b) * c);
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(!(a != b));
            Console.WriteLine(c > b && c > a);
            Console.WriteLine(c > b && c == a);
            Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b || c == a));


        }

    }
}
