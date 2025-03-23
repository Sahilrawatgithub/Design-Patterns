using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Singleton
    {
        private static int count = 0;
        private Singleton()
        {
            count++;
            Console.WriteLine($"Count: {count}");  //this will tell us how many time an instance of this class was created, ideally, it should be one here
        }

        private static readonly Lazy<Singleton> instance=new Lazy<Singleton>(() => new Singleton());  // lazy initialization creates the object only when it's first accessed
        //private static Singleton instance= null;
        public static Singleton GetInstance
        {
            get
            {
                //if ( instance == null)              //if i use lazy initialization, i don't have to use this,also, this is not thread safe
                //{
                //    instance = new Singleton();  
                //}
                //return instance;

                return instance.Value;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
