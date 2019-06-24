using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IOrder order;
            while (true)
            {
                Console.WriteLine("Please Enter Your Order Type:");
                int orderType = Convert.ToInt32(Console.ReadLine());
                if (orderType == (int)Utility.OrderType.FinishedOrder)
                {
                    break;
                }
                else
                {
                    switch (orderType)
                    {
                        case (int)Utility.OrderType.GadgetOrder:
                            order = new GadgetOrder();
                            break;
                        case (int)Utility.OrderType.FoodOrder:
                            order = new FoodOrder();
                            break;
                        default:
                            order = null;
                            break;
                    }
                    var obj = new Order
                    {
                        CustomerId = "C001",
                        OrderId = 1,
                        OrderDate = DateTime.Now,
                        Amount = 10000,
                    };
                    order.CreateOrder(obj);
                    foreach (var item in order.GetList())
                    {
                        Console.WriteLine($"Order Id: {item.OrderId}, Customer Id:{item.CustomerId}, Amount: {item.Amount}");
                    }
                }
            }
            Console.ReadKey();
                
        }
    }
}
