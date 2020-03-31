using System.Collections.Generic;

namespace MoshClass
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        public Customer()
        {

        }
        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if(rating == 0)
                System.Console.WriteLine("Promoted to level 1");
            else
                System.Console.WriteLine("Promoted to leve 2");
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
