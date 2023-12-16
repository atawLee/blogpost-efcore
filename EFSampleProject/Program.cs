// See https://aka.ms/new-console-template for more information

using EFSampleProject.context;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var collection = new ServiceCollection();
collection.AddDbContext<BbsContext>();