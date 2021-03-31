namespace FacadeDesignPattern
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    public class ItemInBasket
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
    public class CourierCompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
    }
}