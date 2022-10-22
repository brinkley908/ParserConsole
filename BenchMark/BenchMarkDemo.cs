using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using ParserConsole.Service;
using Microsoft.Extensions.DependencyInjection;
using Parser;
using CommandLine;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;

namespace BenchMark
{
   // [InProcessAttribute]
    [MemoryDiagnoser]
   
    public class BenchMarkDemo
    {

        ServiceCollection services = new ServiceCollection();
        cParserDemo p2;

        public BenchMarkDemo()
        {

            using ServiceProvider serviceProvider = services.BuildServiceProvider();
            p2 = serviceProvider.GetRequiredService<cParserDemo>();

        }

        //[Benchmark(Baseline = true)]
        //public unsafe void xParserDEmo()
        //{
        //    p1.FileName = "E:\\Dev\\ParserConsole\\ParserConsole\\Scripts\\text.xcs";
        //    p1.RunScript();

        //}

        [Benchmark]
        public void cParserDEmo()
        {
            p2.FileName = "E:\\Dev\\ParserConsole\\ParserConsole\\Scripts\\test.cs";
            p2.RunScript();
        }

    }
}
