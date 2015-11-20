﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson10
{
    public class Ping
    {

        public event PingPong Striked;

        public void Message()
        {
            Console.WriteLine("Это был Пинг - принял удар");
            System.Threading.Thread.Sleep(1000);
            Striked.Invoke();
        }

    }
}
