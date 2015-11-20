using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson10
{
    public class Hunter
    {
        public event RabbitMove HunterDid;



        public void Scream(int a, int b)
        {
            //Console.WriteLine("F*cking rabbit over there: " + a + ", " + b);

            HunterDid.Invoke(a, b);
        }

    }
}
