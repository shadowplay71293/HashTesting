using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s;
            long resultado;
            Program objeto = new Program();

            Console.WriteLine("Introduce la palabra");

            s= Console.ReadLine();


            resultado = Program.hashfunction(s);

            Console.WriteLine(resultado);
            Console.Read();

            
        }
        public static Int64 hashfunction(string s) {

             Int64 h;
            string letters;
            int i;
            int index;
            long inc;

            h = 7;
            letters = "acdegilmnoprstuw";

            for(i=0; i<s.Length;i++) {
                inc = h * 37;
                index = letters.IndexOf(s[i]);
                h = inc + index;
            }

            return h;
        }
    }
}
