using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithInterface
{
    public class GadgetOrder : IOrder
    {
        public Order CreateOrder(Order order)
        {
            order.OrderType = (int)Utility.OrderType.GadgetOrder;
            order.Discount = Utility.GadgetDiscount;
            Utility.OrderList.Add(order);
            return order;
        }

        public List<Order> GetList()
        {
            List<Order> list = new List<Order>();
            foreach (Order item in Utility.OrderList)
            {
                if (item.OrderType == (int)Utility.OrderType.GadgetOrder)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public Customer Registration(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
