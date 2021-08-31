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
        // private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;

        private static void Main(string[] args)
        {
          Log.Logger = new LoggerConfiguration().WriteTo.File(_loggerFile).CreateLogger();

          runProgram();
        }

        private static void runProgram()
        {
          Log.Information("method: runProgram()");
          MakeASelection<Customer>(_customerSingleton.Customers);
          MakeASelection<Bookstore>(_storeSingleton.Bookstores);
          // Console.WriteLine(SelectAStore());
          // Console.WriteLine(SelectACustomer());
          // Console.WriteLine(SelectProducts());
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
          // foreach(var customer in _customerSingleton.Customers)
          // {
          //   System.Console.WriteLine(i + ": " + customer);
          //   i += 1;
          // }
          // foreach(var product in _productSingleton.Products)
          // {
          //   System.Console.WriteLine(i + ": " + product);
          //   i += 1;
          // }
        }

        private static int MakeASelection<T>(List<T> data) where T : class
        {
          Log.Information($"method: MakeASelection<{typeof(T)}>()");

          PrintRepoContent<T>(data);
          string type = typeof(T).ToString();
          string name = type.Substring(type.LastIndexOf(".") + 1);

          Console.WriteLine($"Select a {name}:");

          var selection = int.Parse(Console.ReadLine());

          return selection;
        }

        // private static Bookstore SelectAStore()
        // {
        //   Log.Information("method: SelectAStore()");

        //   Console.WriteLine("Select a Bookstore: ");

        //   var option = int.Parse(Console.ReadLine());
        //   var store = _storeSingleton.Bookstores[option - 1];

        //   return store;
        // }

        // private static Customer SelectACustomer()
        // {
        //   Log.Information("method: SelectACustomer()");

        //   Console.WriteLine("Select a Customer: ");

        //   var option = int.Parse(Console.ReadLine());
        //   var customer = _customerSingleton.Customers[option - 1];

        //   return customer;
        // }

        // private static Product SelectProducts()
        // {
        //   Log.Information("method: SelectProducts()");

        //   Console.WriteLine("Select a Product(s): ");

        //   var option = int.Parse(Console.ReadLine());
        //   var product = _productSingleton.Products[option - 1];

        //   return product;
        // }
    }
}
