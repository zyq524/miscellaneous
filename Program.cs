using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.Classic;
using CommandLine;

namespace Miscellaneous
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            var parser = new CommandLineParser();
            if (parser.ParseArguments(args, options))
            {
                if (!string.IsNullOrEmpty(options.Name))
                {
                    switch(options.Name)
                    {
                        case "ClassicObserver":
                            ClassicObserver();
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.Write("No argument");
            }
            Console.ReadLine();
        }

        private static void ClassicObserver()
        {
            var observerA = new ObserverA();
            var observerB = new ObserverB();
            var clock = new Clock("Bomb!", 2);
            clock.Add(observerA);
            clock.Add(observerB);
            clock.Alert();
        }
    }
}
