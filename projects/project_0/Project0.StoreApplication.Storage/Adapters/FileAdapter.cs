using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Project0.StoreApplication.Storage.Adapters
{
  /// <summary>
  /// XML Serializer
  /// </summary>
  public class FileAdapter
  {
    /// <summary>
    /// Generic ReadFromFile method
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public List<T> ReadFromFile<T>(string path) where T : class
    {
      if(!File.Exists(path))
      {
        return null;
      }
      var file = new StreamReader(path);
      var xml = new XmlSerializer(typeof(List<T>));
      var repository = xml.Deserialize(file) as List<T>;
      return repository;
    }

    /// <summary>
    /// Generic SaveToFile method
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public void SaveToFile<T>(string path, List<T> repository) where T : class
    {
      var file = new StreamWriter(path);
      var xml = new XmlSerializer(typeof(List<T>));
      xml.Serialize(file, repository);
      file.Close();
    }
  }
}