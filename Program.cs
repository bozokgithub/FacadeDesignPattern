using System;
using System.Collections.Generic;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderFacade orderFacade = new OrderFacade();
            List<ItemInBasket> items = new List<ItemInBasket>
            {
                new ItemInBasket(){ Id=1, ItemName= "X", Price= 40, Quantity= 2},
                new ItemInBasket(){ Id=2, ItemName= "Y", Price= 9, Quantity= 20},
                new ItemInBasket(){ Id=1, ItemName= "Z", Price= 10, Quantity= 8},
                new ItemInBasket(){ Id=1, ItemName= "Q", Price= 25, Quantity= 5}
            };
            orderFacade.GiveOrder("Roksana", "Poczta Polska", items);
            Console.ReadLine();
        }
    }
}