using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab012_Exit
{

    class MyConsole

    {

        Dictionary<string, string> myDictionary = new Dictionary<string, string>();

        public MyConsole()
        {
            myDictionary.Add("stop", "exit");
            myDictionary.Add("exit", "exit");
            myDictionary.Add("quit", "exit");
            myDictionary.Add("end", "exit");
            myDictionary.Add("start", "start");
            myDictionary.Add("execute", "start");
            myDictionary.Add("print", "print");
        }

        public void Start()
        {
            
            Console.WriteLine("Write start or execute to start a program");
            string input = Console.ReadLine();
            input = input.ToLower();

            if(input.Equals("start")) {
                Console.WriteLine("The program has started");
                Print();
                End();
            }
        }
            
            

        public void Print()
        {
                       
            Console.WriteLine("Check the key of the command ");
            string input = Console.ReadLine();
            input = input.ToLower();
            //string output = in myDictionary.Keys;
            Console.WriteLine(input + "  " + myDictionary[input]);
        }

        public void End()
        {
            Console.WriteLine("The program has ended");
            
        }

    }
}
