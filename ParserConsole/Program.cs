// See https://aka.ms/new-console-template for more information

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Parser;
using Parser.Service;
using ParserConsole.Service;
using Security.Models.ASpNet;
using System.Text;

var services = new ServiceCollection();

services.AddScoped<IParserService, ParserService>();
services.AddScoped<cParserDemo>();
services.AddScoped<IFileIOService, FileIOService>();

services.AddIdentity<IdentityUser, IdentityRole>(
        options =>
        {
            options.SignIn.RequireConfirmedAccount = false;

            //Other options go here
        }
        )
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        { 
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = Jwt.Issuer,
            ValidAudience = Jwt.Issuer,
            IssuerSigningKey = new
            SymmetricSecurityKey
            (Encoding.UTF8.GetBytes
            (Jwt.Key))
        };
    });

using ServiceProvider serviceProvider = services.BuildServiceProvider();

var cParser = serviceProvider.GetRequiredService<cParserDemo>();

while (true)
{
    Console.WriteLine("\r\nEnter File Name (exit, quit or q to quit)");
    var file = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(file)) file = "test";

    if (file.ToLower()=="exit" || file.ToLower() == "quit" || file.ToLower() == "q") break;


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