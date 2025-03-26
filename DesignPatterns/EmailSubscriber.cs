using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class EmailSubscriber : ISubscriber
    {
        private string name;

        public EmailSubscriber(string name)
        {
            this.name = name;
        }
        public void Update(string news)
        {
            Console.WriteLine($"{name} received news via email: {news}");
        }
    }
}
