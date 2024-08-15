// See https://aka.ms/new-console-template for more information
using _14_NTierMapping.DAL;
using _14_NTierMapping.DATA;

Console.WriteLine("Hello, World!");

AppDbContext context = new AppDbContext();
context.Filmler.Add(new Film());