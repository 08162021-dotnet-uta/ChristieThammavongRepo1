using System.Collections.Generic;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Repositories;

namespace Project0.StoreApplication.Client.Singletons
{
  /// <summary>
  /// Singleton for Orders
  /// </summary>
  public class OrderSingleton
  {
    public List<Order> Orders { get; private set; }
    private static OrderSingleton _orderSingleton;
    private static readonly OrderRepository _orderRepository = new OrderRepository();
    /// <summary>
    /// Handler of Singleton Design Pattern for Orders
    /// </summary>
    /// <value></value>
    public static OrderSingleton Instance 
    {
      get
      {
        if (_orderSingleton == null)
        {
          _orderSingleton = new OrderSingleton();
        }

        return _orderSingleton;
      }
    }
    /// <summary>
    /// Stores repository of orders
    /// </summary>
    private OrderSingleton()
    {
      Orders = _orderRepository.Select();
    }
    /// <summary>
    /// This Add method will create/add a new order
    /// </summary>
    /// <param name="order"></param>    
    public void Add(Order order)
    {
      _orderRepository.Insert(order);
      Orders = _orderRepository.Select();
    }
    /// <summary>
    /// This will save the orders
    /// SaveOrder method from Akil Tomlinson
    /// </summary>
    public void SaveOrder()
    {
      _orderRepository.Save(Orders);
      Orders = _orderRepository.Select();
    }
  }
}