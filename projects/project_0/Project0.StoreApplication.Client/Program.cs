using System;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;
using Serilog;

namespace Project0.StoreApplication.Client
{
    internal class Program
    {

        private const string _loggerFile = @"/home/christie/revature/christie_repo/data/logs.txt";
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(_loggerFile).CreateLogger();
            var p = new Program();

            p.PrintRepoContent();
            Console.WriteLine(p.SelectAStore());
        }

        void PrintRepoContent()
        {
          Log.Information("method: PrintRepoContent()");
          var storeRepository = new StoreRepository();
          int i = 1;

          foreach(var bookstore in storeRepository.Bookstores)
          {
            System.Console.WriteLine(i + ": " + bookstore);
            i += 1;
          }
        }

        Bookstore SelectAStore()
        {
          Log.Information("method: SelectAStore()");
          var sr = new StoreRepository().Bookstores;

          Console.WriteLine("Select a Bookstore: ");

          var option = int.Parse(Console.ReadLine());
          var store = sr[option - 1];

          return store;
        }
    }
}
