using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class SMSSubscriber : ISubscriber
    {
        private string name;

        public SMSSubscriber(string name)
        {
            this.name = name;
        }
        
        public void Update(string news)
        {
            Console.WriteLine($"{name} received news via SMS: {news}");
        }
    }
}


