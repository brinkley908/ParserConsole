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

cParser.FileName = "E:\\Dev\\ParserConsole\\ParserConsole\\Scripts\\test.cs";
cParser.RunScript();

Console.ReadKey();
