using System;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            #region Fibonacci -> texto
            Console.WriteLine("Ingrese un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            double n1 = 0, n2 = 1, sum_n1_n2, sum = 1;
            string fibo = string.Format($"{n1:N0}\t{n2:N0}\t");
            for (int i = 2; i <= a; i++)
            {
                sum_n1_n2 = n1 + n2;
                fibo += string.Format($"{sum_n1_n2:N0}\t");
                sum += n2;
                n1 = n2;
                n2 = sum_n1_n2;
            }
            Console.Write($"{fibo}");
            Console.WriteLine($"\nSumatoria = \t{sum}");
            #endregion

            #region Fibonacci -> arreglo
            //Console.WriteLine("Ingresa un numero");
            //var n = Convert.ToInt32(Console.ReadLine());
            //var arreglo = new double[n];
            //arreglo[0] = 0;
            //arreglo[1] = 1;
            //for (int i = 2; i < n; i++)
            //{
            //    double a = arreglo[i - 1];
            //    double b = arreglo[i - 2];
            //    arreglo[i] = a + b;
            //}
            //double sum = 0;
            //for (int j = 0; j < arreglo.Length; j++)
            //{
            //    sum += arreglo[j];
            //    Console.Write($"{arreglo[j]:N0}\t");
            //}
            //Console.WriteLine("");
            //Console.WriteLine("SUMA: "+sum);
            #endregion

            #region Arreglos
            //var a = new int[5, 5];
            //var b = new int[5, 5];
            //var n = new int[5, 5];

            //var arreglo = new ArreglosOps();

            //var _arregloA = arreglo.RellenarArreglo(x: a);
            //var _arregloB = arreglo.RellenarArreglo(x: b);

            //arreglo.LeerArreglo(x: _arregloA);
            //arreglo.LeerArreglo(x: _arregloB);
            //arreglo.LeerArreglo(arreglo.MultiplicarArreglo(x: _arregloA, y: _arregloB, n: n));
            #endregion

            #region TimeSpan
            //var a = new TimeSpan(0, 0, 20);
            //Console.WriteLine(a);


            ////for (int i = a.Minutes; i >= 0; i--)
            //{
            //    Thread.Sleep(new TimeSpan(0, 1, 0));
            //    Console.WriteLine($"m: { i}");
            //}

            #endregion

            #region Password Generator
            //var r = new Random();
            //var buffer = new char[10];
            //for (int i = 0; i < buffer.Length; i++)
            //{
            //    buffer[i] = (char)(r.Next(48, 122));
            //}
            //var password = new string(buffer);

            //Console.WriteLine(password);

            #endregion

            #region string Interpolation + ifonline
            //var a = 12;
            //Console.WriteLine($"str value: { (a == 1 ? "si" : "no")}");
            #endregion

            #region Diccionario de datos
            //Dictionary<int, string> HttpWebErrors = new Dictionary<int, string>
            //{
            //    [301] = "The page requested has been permanently moved",
            //    [307] = "The requested resource is available only through a proxy",
            //    [403] = "Access forbidden by the server",
            //    [404] = "Page not found. Try to change the URL",
            //    [408] = "Request timeout. Try again."
            //};
            //foreach (var item in HttpWebErrors)
            //{
            //    Console.WriteLine($"{(item.Key == 301 ? $"key: {item.Key} value: {item.Value}" : $"nope : {item.Key}")}");
            //    Console.WriteLine("\n");
            //    Console.WriteLine($"key: {item.Key}  value: {item.Value}");
            //}
            #endregion

            #region Padleft
            //var a = "123 456 789";
            //for (int i = 0; i <= a.Length-1; i++)
            //{
            //    Console.WriteLine(a[i].ToString().PadLeft(i+1, (char)92));
            //}
            #endregion

            #region Otros
            //Console.WriteLine("ingrese frase");
            //var a = Console.ReadLine();

            //Console.WriteLine(a.Replace(@"\\n",@"\n"));

            //var numeros = new[] { 1, 2, 3, 4, 5 };

            //Array.Clear(numeros, 1,1);
            //foreach (var item in numeros)
            //{
            //    Console.Write($" {item}");

            //}
            #endregion

            Console.ReadKey();
        }

    }

}
