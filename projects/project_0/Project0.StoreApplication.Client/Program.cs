using System;
using Project0.StoreApplication.Client.Singletons;
using Project0.StoreApplication.Domain.Models;
using Serilog;

namespace Project0.StoreApplication.Client
{
    internal class Program
    {
        private const string _loggerFile = @"/home/christie/revature/christie_repo/data/logs.txt";
        private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;

        private static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration().WriteTo.File(_loggerFile).CreateLogger();

            runProgram();
        }

        private static void runProgram()
        {
          Log.Information("method: runProgram()");
          PrintRepoContent();
          Console.WriteLine(SelectAStore());
        }

        private static void PrintRepoContent()
        {
          Log.Information("method: PrintRepoContent()");
          int i = 1;

          foreach(var bookstore in _storeSingleton.Bookstores)
          {
            System.Console.WriteLine(i + ": " + bookstore);
            i += 1;
          }
        }

        private static Bookstore SelectAStore()
        {
          Log.Information("method: SelectAStore()");

          Console.WriteLine("Select a Bookstore: ");

          var option = int.Parse(Console.ReadLine());
          var store = _storeSingleton.Bookstores[option - 1];

          return store;
        }
    }
}
