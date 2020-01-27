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

        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// For testing nullable dates
        /// </summary>
        public DateTime? OptionalDate { get; set; }

        public enum CustomerTypes { Ltd, SoleTrader, PLC }

        public static string[] GetCustomerTypes()
        {
            return Enum.GetNames(typeof(CustomerTypes));
        }
    }
}
