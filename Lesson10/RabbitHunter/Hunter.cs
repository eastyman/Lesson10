using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson10
{
    public class Hunter
    {
        public event RabbitMove HunterDid;

        //метод подписан на событие зайца - параметры приходят оттуда
        public void Scream(int a, int b)
        {
            //Console.WriteLine("F*cking rabbit is over there: " + a + ", " + b);

            //вызов события охотника в методе, подписанном на событие зайца
            HunterDid.Invoke(a, b);
        }

    }
}
