using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    public sealed class SingletonPattern
    {
        SingletonPattern() { }

        static readonly SingletonPattern instance = new SingletonPattern();

        public static SingletonPattern Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
