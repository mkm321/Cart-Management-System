using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            Item item = new Item();
            item.ItemID = 1;
            item.ItemName = "Product1";
            item.ItemPrice = 40.5;
            item.ItemQuantity = 1;
            cart.AddItems(item);
            Item item2 = new Item();
            item2.ItemID = 2;
            item2.ItemName = "Product2";
            item2.ItemPrice = 5.8;
            item2.ItemQuantity = 7;
            cart.AddItems(item2);
            cart.ShowCart();
            Console.WriteLine();
            Console.WriteLine("After Removing");
            cart.RemoveItems(item);
            cart.ShowCart();
            Console.WriteLine(cart.TotalAmount());
            CardPayment cardPayment = new CardPayment();
            cart.PaymentDetails(cardPayment);
            CashPayment cashPayment = new CashPayment();
            cart.PaymentDetails(cashPayment);
            Console.ReadKey();
        }
    }
}
