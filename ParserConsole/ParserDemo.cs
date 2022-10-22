using Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserConsole
{
    public class ParserDemo
    {
        private IParser _parser;

        public ParserDemo(IParser parser)
        {
            _parser = parser;
        }

        public void Run()
        {
            Console.WriteLine("Parser Demo");
            _parser.RunScript("test.cs");
        }

    }
}
