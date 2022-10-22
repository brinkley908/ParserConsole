// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Parser;
using ParserConsole.Service;

var services = new ServiceCollection();

services.AddScoped<IParserService, ParserService>();
services.AddScoped<cParserDemo>();
services.AddScoped<IFileIOService, FileIOService>();

using ServiceProvider serviceProvider = services.BuildServiceProvider();
var cParser = serviceProvider.GetRequiredService<cParserDemo>();

while (true)
{
    Console.WriteLine("\r\nEnter File Name (exit, quit or q to quit)");
    var file = Console.ReadLine();
    
    if(file.ToLower()=="exit" || file.ToLower() == "quit" || file.ToLower() == "q") break;

    if (string.IsNullOrWhiteSpace(file)) file = "test";

    cParser.FileName = $"E:\\Dev\\ParserConsole\\ParserConsole\\Scripts\\{file}.cs";
    //cParser.Compile();
    try
    {
        cParser.RunScript();
    }
    catch(ParserException p)
    {
        Console.WriteLine(p.Message);
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}