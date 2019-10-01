using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvGrundlaggandeModellering
{
    class Program
    {
        static void Main(string[] args)
        {


            Book b1 = new Book();



            string n1 = b1.GetName();
            Console.WriteLine(n1);

            string c1 = b1.GetCategory();
            Console.WriteLine(c1);



            Console.ReadKey();
        }
    }
}
