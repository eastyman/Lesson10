using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Ping ping = new Ping();
            //Pong pong = new Pong();

            //ping.Striked += pong.Message;
            //pong.Striked += ping.Message;
            ////start game
            //ping.Message();

            //2
            Rabbit bunny = new Rabbit();
            Hunter angry = new Hunter();

            //"подписали" метод охотника на событие зайца
            bunny.RabbitMoved += angry.Scream;


            //3
            // A    событие охотника через анонимный метод
            //angry.HunterDid += delegate(int a, int b) 
            //{
            //    Console.WriteLine("F*cking rabbit is over there: " + a + ", " + b);
            //};

            // L    событие охотника через лямбда-выражение
            angry.HunterDid += (a, b) => Console.WriteLine("F*cking rabbit is over there: " + a + ", " + b);


            //десять перемещений зайца
            for (int i = 0; i <= 10; i++)
            {
                bunny.Move();
            }



        }
    }
}
