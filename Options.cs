using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;

namespace Miscellaneous
{
    class Options
    {
        [Option("n", "name", Required = true, HelpText = "The name of the function to call")]
        public string Name { get; set; }

    }
}
