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

            bunny.RabbitMoved += angry.Scream;


            //3
            // A
            angry.HunterDid += delegate(int a, int b) 
            {
                Console.WriteLine("F*cking rabbit over there: " + a + ", " + b);
            };
            // L
            //angry.HunterDid += (a, b) => Console.WriteLine("F*cking rabbit over there: " + a + ", " + b);

            for (int i = 0; i <= 10; i++)
            {
                bunny.Move();
            }



        }
    }
}
