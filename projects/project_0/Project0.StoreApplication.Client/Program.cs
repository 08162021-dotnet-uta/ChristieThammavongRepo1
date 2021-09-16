using System;
using System.Collections.Generic;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage;
using Serilog;

namespace Project0.StoreApplication.Client
{
    internal class Program
    {
        private const string _loggerFile = @"/home/christie/revature/christie_repo/data/logs.txt";
        private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
        private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
        private static readonly ProductSingleton _productSingleton = ProductSingleton.Instance;
        private static readonly OrderSingleton _orderSingleton = OrderSingleton.Instance;

        private static void Main(string[] args)
        {
          Log.Logger = new LoggerConfiguration().WriteTo.File(_loggerFile).CreateLogger();

          runProgram();
          // HelloSQL();
        }

        private static void runProgram()
        {
          Log.Information("method: runProgram()");
          Console.WriteLine("Are you a customer or a store representative? \n Type C for customer \n Type S for store representative");
          string role = Console.ReadLine();
          if (role == "C")
          {
            Log.Information("role: customer");
            var customer = _customerSingleton.Customers[MakeASelection<Customer>(_customerSingleton.Customers)];
            var bookstore = _storeSingleton.Bookstores[MakeASelection<Bookstore>(_storeSingleton.Bookstores)];
            var product = _productSingleton.Products[MakeASelection<Product>(_productSingleton.Products)];
            Log.Information("add a new order");
            // Create a new Order using Add method - from Joshua Posada
            _orderSingleton.Orders.Add( new Order { Customer = customer, Bookstore = bookstore, Product = product, OrderDate = DateTime.Now});
            // SaveOrder method from Akil Tomlinson
            _orderSingleton.SaveOrder();
            PrintLastContent<Order>(_orderSingleton.Orders);
          }
          else if (role == "S")
          {
            Log.Information("role: store representative");
            //var bookstore = _storeSingleton.Bookstores[MakeASelection<Bookstore>(_storeSingleton.Bookstores)];
            PrintRepoContent<Order>(_orderSingleton.Orders);
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

        private static void PrintLastContent<T>(List<T> data) where T : class
        {
          Log.Information($"method: PrintLastContent<{typeof(T)}>()");
          int i = data.Count - 1;
            
          System.Console.WriteLine(data[i]);
        }

        private static int MakeASelection<T>(List<T> data) where T : class
        {
          Log.Information($"method: MakeASelection<{typeof(T)}>()");

          PrintRepoContent<T>(data);
          string type = typeof(T).ToString();
          string name = type.Substring(type.LastIndexOf(".") + 1);

          Console.WriteLine($"Select a {name}:");
          
          var selection = int.Parse(Console.ReadLine());

          if (selection - 1 < data.Count)
          {
            return selection - 1;
          }
          else
          {
            Log.Information("Invalid selection");
            Console.WriteLine("Your selection is not valid.");
            return -1;
          }
        }

        // private static void HelloSQL()
        // {
        //   var def = new EF();

        //     // def.SetCustomer(new Customer());

        //   foreach (var item in def.GetCustomers())
        //   {
        //     Console.WriteLine(item);
        //   }
        // }
    }
}
