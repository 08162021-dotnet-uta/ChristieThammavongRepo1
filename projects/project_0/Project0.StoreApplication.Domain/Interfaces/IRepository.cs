using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Interfaces
{
  /// <summary>
  /// Interface for repositories
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IRepository<T> where T : class
  {
    /// <summary>
    /// Insert method
    /// </summary>
    /// <returns></returns>
    bool Insert();
    /// <summary>
    /// Update method
    /// </summary>
    /// <returns></returns>
    T Update();
    /// <summary>
    /// Select method
    /// </summary>
    /// <returns></returns>
    List<T> Select();
    /// <summary>
    /// Delete method
    /// </summary>
    /// <returns></returns>
    bool Delete();
  }
}