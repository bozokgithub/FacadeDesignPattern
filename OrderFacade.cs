using System;
using System.Collections.Generic;

namespace FacadeDesignPattern
{
    public class OrderFacade
    {
        private Customer customer;
        private CourierCompany courierCompany;
        private ItemProcessing itemProcessing = new ItemProcessing();
        private OrderProcessing orderProcessing = new OrderProcessing();
        private OrderDetails orderDetails = new OrderDetails();


        public void GiveOrder(string customerName, string chosenCourierCompany, List<ItemInBasket> items)
        {
            customer = new Customer() { Name = customerName };
            courierCompany = new CourierCompany() { Name = chosenCourierCompany };
            int orderId = orderProcessing.AddOrder(DateTime.Now, customer, courierCompany);
            orderDetails.AddOrderDetails(orderId, items);
            items.ForEach(u => itemProcessing.TakeStock(u.Id, u.Quantity));
            Console.WriteLine();
            Console.WriteLine("Process Completed");


        }

    }
}