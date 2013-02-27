using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.Classic;
using CommandLine;
using DesignPatterns;
using Algorithms;

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
                        case "EventObserver":
                            EventObserver();
                            break;
                        case "Factory":
                            Factory();
                            break;
                        case "Combine":
                            Combine();
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
            var observerA = new ObserverPattern.Classic.ObserverA();
            var observerB = new ObserverPattern.Classic.ObserverB();
            var clock = new ObserverPattern.Classic.Clock();
            clock.Add(observerA);
            clock.Add(observerB);
            clock.Run("Bomb!", 2);
        }

        private static void EventObserver()
        {
            var observerA = new ObserverPattern.Event.ObserverA();
            var observerB = new ObserverPattern.Event.ObserverB();
            var clock = new ObserverPattern.Event.Clock();
            observerA.Subscribe(clock);
            observerB.Subscribe(clock);

            clock.Run("Bomb!", 2);
        }

        private static void Factory()
        {
            FactoryPattern.Creator c = new FactoryPattern.Creator();
            for (int i = 1; i <= 12; i++)
            {
                var product = c.Create(i);
                Console.WriteLine(product.ShipFrom());
            }
        }

        private static void Combine()
        {
            var recursion = new Recursion();
            recursion.Combine("wxyz");
        }
    }
}
