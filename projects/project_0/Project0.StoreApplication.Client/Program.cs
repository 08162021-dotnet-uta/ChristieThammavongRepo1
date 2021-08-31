using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Serilog;

namespace Project0.StoreApplication.Client
{
    internal class Program
    {
        private const string _loggerFile = @"/home/christie/revature/christie_repo/data/logs.txt";
        private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
        private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
        private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;

        private static void Main(string[] args)
        {
          Log.Logger = new LoggerConfiguration().WriteTo.File(_loggerFile).CreateLogger();

          runProgram();
        }

        private static void runProgram()
        {
          Log.Information("method: runProgram()");
          Console.WriteLine("Are you a customer or a store representative? \n Type C for customer \n Type S for store representative");
          string role = Console.ReadLine();
          if (role == "C")
          {
            Log.Information("role: customer");
            MakeASelection<Customer>(_customerSingleton.Customers);
            MakeASelection<Bookstore>(_storeSingleton.Bookstores);
            MakeASelection<Product>(_productSingleton.Products);
          }
          else if (role == "S")
          {
            Log.Information("role: store representative");
            MakeASelection<Bookstore>(_storeSingleton.Bookstores);
          }
          else
          {
            Log.Information("role: input invalid");
            Console.WriteLine("Invalid input.");
          }
        }

        private static void PrintRepoContent<T>(List<T> data) where T : class
        {
          Log.Information($"method: PrintRepoContent<{typeof(T)}>()");
          int i = 1;

          foreach(var item in data)
          {
            System.Console.WriteLine(i + ": " + item);
            i += 1;
          }
        }

        private static int MakeASelection<T>(List<T> data) where T : class
        {
          Log.Information($"method: MakeASelection<{typeof(T)}>()");

          PrintRepoContent<T>(data);
          string type = typeof(T).ToString();
          string name = type.Substring(type.LastIndexOf(".") + 1);

          Console.WriteLine($"Select a {name}:");
          
          var selection = int.Parse(Console.ReadLine());

          if (selection < data.Count)
          {
            return selection;
          }
          else
          {
            Console.WriteLine("Your selection is not valid.");
            return -1;
          }
        }
    }
}
