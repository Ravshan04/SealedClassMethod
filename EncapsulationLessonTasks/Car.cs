using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //....
        }

        public class Asosiy
        {
            // voris bo'ladigan method
            public virtual int Add(int a, int b)
            {
                return a + b;
            }
        }

        //asosiy classdan voris olish
        public class Voris1 : Asosiy
        {
            //voris bo'lgan methodni sealed qilish
            public sealed override int Add(int a, int b)
            {
                return a + b;
            }
        }

        public class Inherit : Voris1
        {
            public override int Add(int a, int b)
            {
                return base.Add(a, b);
            }
        }
    }
}