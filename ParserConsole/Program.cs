// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Microsoft.Extensions.DependencyInjection;
using Parser;
using ParserConsole;
using ParserConsole.Service;

var services = new ServiceCollection();

services.AddScoped<cParser>();
services.AddScoped<cParserDemo>();

using ServiceProvider serviceProvider = services.BuildServiceProvider();
var cParser = serviceProvider.GetRequiredService<cParserDemo>();

cParser.FileName = "E:\\Dev\\ParserConsole\\ParserConsole\\Scripts\\test.cs";
cParser.RunScript();

Console.ReadKey();
