using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n, unidades, n2, decenas, n3, centenas, millares;
            // generar un número aleatorio de cuatro cifras sin cifras repetidas
            bool repetidas = true;
            do
            {
                n = random.Next(0, 10000);
                //Console.WriteLine(n);
                unidades = n % 10;
                n2 = (n - unidades) / 10;
                decenas = n2 % 10;
                n3 = (n2 - decenas) / 10;
                centenas = n3 % 10;
                millares = (n3 - centenas) / 10;
                repetidas = false;
                if (unidades == decenas || unidades == centenas || unidades == millares || decenas == centenas || decenas == millares || centenas == millares)
                {
                    repetidas = true;
                }
            } while (repetidas);
            //Console.WriteLine(n);
            bool ok = false;
            do {
                int fijas = 0;
                int picas = 0;
                Console.Write("Ingrese un número de cuatro dígitos: ");
                int h = int.Parse(Console.ReadLine());
                //Console.WriteLine(h);
                Console.WriteLine();
                int u = h % 10;
                int m2 = (h - u) / 10;
                int d = m2 % 10;
                int m3 = (m2 - d) / 10;
                int c = m3 % 10;
                int m = (m3 - c) / 10;

                if (u == unidades) { fijas++; }
                if (d == decenas) { fijas++; }
                if (c == centenas) { fijas++; }
                if (m == millares) { fijas++; }

                if (u == decenas || u == centenas || u == millares) { picas++; }
                if (d == unidades || d == centenas || d == millares) { picas++; }
                if (c == unidades || c == decenas || c == millares) { picas++; }
                if (m == unidades || m == decenas || m == centenas) { picas++; }

                Console.WriteLine($"PICAS: {picas},      FIJAS: {fijas}");

                ok = fijas == 4;

            }
            while (!ok);
            Console.WriteLine("Correcto");
            Console.ReadLine();
        }
    }
}