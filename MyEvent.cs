using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_9
{
    delegate void MyEventHandler();

    class MyEvent
    {
        public void Message()
        {
            Console.WriteLine("Добавлен новый элемент.");
        }
    }
}
