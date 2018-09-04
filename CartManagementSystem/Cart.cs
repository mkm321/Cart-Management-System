using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementSystem
{
    class Cart : ICartInterface
    {
        List<Item> items = new List<Item>();
        double totalAmount = 0;
        public void AddItems(Item item)
        {
            items.Add(item);
        }

        public void PaymentDetails(IPayment payment)
        {
            payment.SaveBankingDetails();
        }

        public void RemoveItems(Item item)
        {
            items.Remove(item);
        }

        public void ShowCart()
        {
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine("Item Id " + items[i].itemID);
                Console.WriteLine("Item Name " + items[i].itemName);
                Console.WriteLine("Item Price " + items[i].itemPrice);
                Console.WriteLine("Item Quantity " + items[i].itemQuantity);
            }
        }

        public double TotalAmount()
        {
            for(int i = 0; i < items.Count; i++)
            {
                totalAmount += (items[i].itemPrice * items[i].itemQuantity);
            }
            return totalAmount;
        }
    }
}
