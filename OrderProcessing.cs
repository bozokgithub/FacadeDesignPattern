using System;
using System.Collections.Generic;
using System.Linq;

namespace FacadeDesignPattern
{
    public class OrderProcessing
    {
        public int AddOrder(DateTime orderDate, Customer customer, CourierCompany courierCompany)
        {
            Console.WriteLine(" on {0}:  {1}'s order is taken. Chosen courier company:{2} ", orderDate.ToString(), customer.Name, courierCompany.Name);
            return 10001;
        }
    }

    public class OrderDetails
    {
        public void AddOrderDetails(int orderId, List<ItemInBasket> items)
        {
            Console.WriteLine("The number of order {0}, ordered items :", orderId);
            Console.WriteLine("...............................");
            items.ForEach(u => Console.WriteLine(" {1} piece of item: {0} has added. sub total:{2}", u.ItemName, u.Quantity, u.Quantity * u.Price));
            Console.WriteLine("...............................");
            var sum = items.Sum(x => x.Price * x.Quantity);
            Console.WriteLine("Total Price: {0}", sum);

        }
    }


    public class ItemProcessing
    {
        public void TakeStock(int itemId, int quantity)
        {
            Console.WriteLine(" Item ID: {0} ; {1} piece/s dropped from stock.", itemId, quantity);
        }
    }
}