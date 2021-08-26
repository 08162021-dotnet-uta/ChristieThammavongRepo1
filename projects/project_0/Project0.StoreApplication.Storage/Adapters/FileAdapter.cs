using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class FileAdapter
  {
    public List<Bookstore> ReadFromFile(string path)
    {
      // file path
      //var path = @"/home/christie/revature/christie_repo/data/bookstores.xml";
      // open file
      if(!File.Exists(path))
      {
        return null;
      }
      var file = new StreamReader(path);
      // serialize object
      var xml = new XmlSerializer(typeof(List<Bookstore>));
      // write to file
      var bookstoreList = xml.Deserialize(file) as List<Bookstore>;
      // close file
      return bookstoreList;
    }

    public void SaveToFile(string path, List<Bookstore> bookstores)
    {
      // file path
      //var path = @"/home/christie/revature/christie_repo/data/bookstores.xml";
      // open file
      var file = new StreamWriter(path);
      // serialize object
      var xml = new XmlSerializer(typeof(List<Bookstore>));
      // write to file
      xml.Serialize(file, bookstores);
      // close file
      file.Close();
    }
  }
}