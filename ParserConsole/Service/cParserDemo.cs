using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Parser;
    
namespace ParserConsole.Service
{
    public class cParserDemo
    {


        private readonly Parser.IParserService _parser;

        public cParserDemo(IParserService parser)
        {
            _parser = parser;
        }

        public string FileName { get; set; } = string.Empty;

        public void RunScript()
        {
            var timer = new Stopwatch();

            if (!_parser.LoadFile(FileName))
                return;
            timer.Start();

            _parser.Run();

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine(foo);
        }

        public void Compile()
        {
            _parser.Compile(FileName);
        }

    }

}
