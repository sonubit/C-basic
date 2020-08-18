using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class workingtask
    {
        public bool IsComplete { get; private set; }

    public async void  Work()
        {
            this.IsComplete = false;
            Console.WriteLine("work");
            Task t=new Task(Working);          
            Console.WriteLine("complete");
        }
       private void Working()
        {
            Console.WriteLine("working");
            Thread.Sleep(2000);
        }
    }
}
