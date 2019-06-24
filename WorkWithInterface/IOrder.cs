using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithInterface
{
    /*interface here....it  use for multiple inhetance access*/
   public interface IOrder
    {
        Customer Registration(Customer customer);
        Order CreateOrder(Order order);
        List<Order> GetList();
    }
}
