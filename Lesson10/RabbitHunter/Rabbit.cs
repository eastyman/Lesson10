using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson10
{
    public class Rabbit
    {
        //событие типа делегата
        public event RabbitMove RabbitMoved;
       // private int x;
       // private int y;

        public int X {get; set;}
        public int Y { get; set; }

        public void Move()
        {
            Random r = new Random();
            X = r.Next();
            Y = r.Next();

            //событие вызывается со случайными параметрами - сигнатура определена делегатом
            RabbitMoved.Invoke(X, Y);
 
        }
    }
}
