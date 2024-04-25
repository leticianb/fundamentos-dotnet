using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fundamentos_dotnet.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} * {y} = {x*y}");
        }
        public void Dividir(double x, double y){
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void Potencia(int x, int y ){
            double pot = Math.Pow(x,y);
            Console.WriteLine($"A potencia de {x} elevado a {y} é {pot}");
        }
        public void Raiz(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine(Math.Round(raiz,2));       
        }
    }
}