namespace MoshClass
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }
}
