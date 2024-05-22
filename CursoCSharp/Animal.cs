using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    internal class Animal
    {
        public virtual void Comer()
        {
            Console.WriteLine("el animal come");
        }
        public void Domir()
        {
            Console.WriteLine("el animal duerme");
        }
    }
}
