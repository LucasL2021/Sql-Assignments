using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.UI;
using ShoppingCart.Data.Models;

namespace ShoppingCart.App
{
    public class Menu
    {
        public void showMenu() 
        {
            Console.WriteLine("Please enter scan to begin scanning products; Enter exit to stop scanning:");
            string str = Console.ReadLine();
            Scan s = new Scan();
            CartItems ci = new CartItems();
            CartService cs = new CartService();

            while (true)
            {
                Console.WriteLine("Please scan the product: ");
                str = Console.ReadLine();
                if (str == "exit") break;
                s.scan(ci, str);
                Console.WriteLine("Product is scanned.");
            }
            Console.WriteLine("Scanning is done.");
            cs.calTotalPrice(ci);
        }
    }
}
