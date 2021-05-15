using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Bill_Calculator.Models
{
    class MenuSource
    {
        private static List<Menu> beverageList;
        private static List<Menu> appetizerList;
        private static List<Menu> maincourseList;
        private static List<Menu> dessertList;
        static MenuSource()
        {
            beverageList = new List<Menu>();
            appetizerList = new List<Menu>();
            maincourseList = new List<Menu>();
            //Beverages
            beverageList.Add(new Menu
            {
                Name = "Soda",
                Category = "Beverage",
                Price = 1.95,
            });
            beverageList.Add(new Menu
            {
                Name = "Tea",
                Category = "Beverage",
                Price = 1.50,
            });
            beverageList.Add(new Menu
            {
                Name = "Coffee",
                Category = "Beverage",
                Price = 1.25,
            });
            beverageList.Add(new Menu
            {
                Name = "Mineral Water",
                Category = "Beverage",
                Price = 2.95,
            });
            beverageList.Add(new Menu
            {
                Name = "Juice",
                Category = "Beverage",
                Price = 2.50,
            });
            beverageList.Add(new Menu
            {
                Name = "Milk",
                Category = "Beverage",
                Price = 1.50,
            });
            //Appetizers
            beverageList.Add(new Menu
            {
                Name = "Buffalo Wings",
                Category = "Appetizer",
                Price = 5.95,
            });
            beverageList.Add(new Menu
            {
                Name = "Potato Skins",
                Category = "Appetizer",
                Price = 8.95,
            });
            appetizerList.Add(new Menu
            {
                Name = "Buffalo Fingers",
                Category = "Appetizer",
                Price = 6.95,
            });
            appetizerList.Add(new Menu
            {
                Name = "Buffalo Wings",
                Category = "Appetizer",
                Price = 5.95,
            });
            appetizerList.Add(new Menu
            {
                Name = "Nachos",
                Category = "Appetizer",
                Price = 8.95,
            });
            appetizerList.Add(new Menu
            {
                Name = "Mushroom Caps",
                Category = "Appetizer",
                Price = 10.95,
            });
            appetizerList.Add(new Menu
            {
                Name = "Shrimp Cpcktail",
                Category = "Appetizer",
                Price = 12.95,
            });
            appetizerList.Add(new Menu
            {
                Name = "Chips and Salsa",
                Category = "Appetizer",
                Price = 6.95,
            });
            //Main course
            maincourseList.Add(new Menu
            {
                Name = "Seafood Alfredo",
                Category = "Main Course",
                Price = 15.95,
            });
            maincourseList.Add(new Menu
            {
                Name = "Chicken Alfredo",
                Category = "Main Course",
                Price = 13.95,
            });
            maincourseList.Add(new Menu
            {
                Name = "Chicekn Picatta",
                Category = "Main Course",
                Price = 13.95,
            });
            maincourseList.Add(new Menu
            {
                Name = "Turkey Club",
                Category = "Main Course",
                Price = 11.95,
            });
            maincourseList.Add(new Menu
            {
                Name = "Lobster Pie",
                Category = "Main Course",
                Price = 19.95,
            });
            maincourseList.Add(new Menu
            {
                Name = "Prime Rib",
                Category = "Main Course",
                Price = 20.95,
            });
            maincourseList.Add(new Menu
            {
                Name = "Shriimp Scampi",
                Category = "Main Course",
                Price = 18.95,
            });
            maincourseList.Add(new Menu
            {
                Name = "Turkey Dinner",
                Category = "Main Course",
                Price = 13.95,
            });
            maincourseList.Add(new Menu
            {
                Name = "Stuffed Chicken",
                Category = "Main Course",
                Price = 14.95,
            });
            //Dessert
            dessertList.Add(new Menu
            {
                Name = "Apple Pie",
                Category = "Dessert",
                Price = 5.95,
            });
            dessertList.Add(new Menu
            {
                Name = "Sundae",
                Category = "Dessert",
                Price = 3.95,
            });
            dessertList.Add(new Menu
            {
                Name = "Carrot Cake",
                Category = "Dessert",
                Price = 5.95,
            });
            dessertList.Add(new Menu
            {
                Name = "Mud Pie",
                Category = "Dessert",
                Price = 4.95,
            });
            dessertList.Add(new Menu
            {
                Name = "Apple Crisp",
                Category = "Dessert",
                Price = 5.95,
            });
        }

        //Methods to use to bind each combo box
        public static List<Menu> getAllBeverages()
        {
            var result = beverageList.ToList<Menu>();
            return result;
        }
        public static List<Menu> getAllAppetizerss()
        {
            var result = appetizerList.ToList<Menu>();
            return result;
        }
        public static List<Menu> getAllMains()
        {
            var result = maincourseList.ToList<Menu>();
            return result;
        }
        public static List<Menu> getAllDesserts()
        {
            var result = dessertList.ToList<Menu>();
            return result;
        }
    }
}
