using System;

namespace U4_programa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4;
            Console.WriteLine("Ingresa un número por favor!");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un número por favor!");
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un número por favor!");
            n3=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el último número por favor!");
            n4=int.Parse(Console.ReadLine());

            if (n1>n2 && n2>n3 && n3>n4) {
                Console.WriteLine("los números estan ordenados de forma decreciente");
            }else{
                Console.WriteLine("los números no estan ordenados de forma decreciente");
            }
        }   
    }
}
