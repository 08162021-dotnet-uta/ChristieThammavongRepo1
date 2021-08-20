using System;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

namespace Project0.StoreApplication.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            var p = new Program();

            p.PrintAllStoreLocations();
            Console.WriteLine(p.SelectAStore());
        }

        void PrintAllStoreLocations()
        {
          Log.Information("method PrintAllStoreLocations");
          var storeRepository = new StoreRepository();
          int i = 1;

          foreach(var store in storeRepository.Stores)
          {
            System.Console.WriteLine(i + " - " + store);
            i += 1;
          }
        }

        Store SelectAStore()
        {
          Log.Information("in method SelectAStore");
          var sr = new StoreRepository().Stores;

          Console.WriteLine("Select a BookStore: ");

          var option = int.Parse(Console.ReadLine());
          var store = sr[option - 1];

          return store;
        }
    }
}
