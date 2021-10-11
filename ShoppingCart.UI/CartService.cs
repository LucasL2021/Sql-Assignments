using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Data.Models;

namespace ShoppingCart.UI
{
    public class CartService
    {
        Dictionary<string, int> summary = new Dictionary<string, int>();
        decimal totalPrice;
        public void calTotalPrice(CartItems ci) 
        {
            foreach (var item in ci.cartList) 
            {
                if (item is Apple) 
                {
                    if (summary.TryGetValue("Apple", out int qty)) summary["Apple"] = summary["Apple"]+1;
                    else summary.Add("Apple", 1);
                }
                if (item is Orange)
                {
                    if (summary.TryGetValue("Orange", out int qty)) summary["Orange"] = summary["Orange"] + 1;
                    else summary.Add("Orange", 1);
                }
            }
            Apple apple = new Apple();
            Orange orange = new Orange();
            totalPrice = summary["Apple"] / apple.PackQuantity * apple.PackPrice + summary["Apple"] % apple.PackQuantity * apple.UnitPrice + summary["Orange"] / orange.PackQuantity * orange.PackPrice + summary["Orange"] % orange.PackQuantity * orange.UnitPrice;
            Console.WriteLine("The total price is " + totalPrice + " dollar.");

        }
    }
}
