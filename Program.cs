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
                        case "EventObserver":
                            EventObserver();
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
    }
}
