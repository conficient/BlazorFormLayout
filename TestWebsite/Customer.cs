using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWebsite
{
    public class Customer
    {
        public string Name { get; set; }

        public string Contact { get; set; }

        public string FavouriteColour { get; set; }

        public int Units { get; set; }

        public decimal Price { get; set; }

        public decimal Total => Units * Price;

        public bool IsPriorityCustomer { get; set; }

        public CustomerTypes CustomerType { get; set; }

        public DeliveryOptions DeliveryOption { get; set; }

        public DateTime DeliveryDate { get; set; }

        public decimal DeliveryCost => GetDeliveryCost();

        /// <summary>
        /// For testing nullable dates
        /// </summary>
        public DateTime? OptionalDate { get; set; }

        public enum CustomerTypes { Ltd, SoleTrader, PLC }

        public enum DeliveryOptions { Standard, Express, Overnight }


        /// <summary>
        /// Must select to proceed
        /// </summary>
        public bool AcceptTerms { get; set; }

        public int CostRegion { get; set; }

        public Dictionary<int, string> GetCostRegions()
        {
            return new Dictionary<int, string>()
            {
                { 100, "North" },
                { 200, "South" },
                { 300, "East" },
                { 400, "West" }
            };
        }

        private decimal GetDeliveryCost()
        {
            switch (DeliveryOption)
            {
                case DeliveryOptions.Standard: return 2.5m;
                case DeliveryOptions.Express: return 5.12m;
                case DeliveryOptions.Overnight: return 9.99m;
                default: throw new NotImplementedException();
            }
        }

    }
}
