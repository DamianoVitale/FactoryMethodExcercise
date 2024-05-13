// See https://aka.ms/new-console-template for more information
using Esercizio1;
using Esercizio1.Library;
using System.Linq.Expressions;

try
{
    var food1 = FoodFactory.Get(FoodEnum.Fruit, "Apple", 1.10);
    var food2 = FoodFactory.Get(FoodEnum.Vegetable, "Carrot ", 0.70);
    var food3 = FoodFactory.Get(FoodEnum.Meat, "Hamburger ", 2.52);
    food1.DisplayInfo();
    food2.DisplayInfo();
food3.DisplayInfo();





    var sc = new ShoppingCart();
    sc.AddItem(food1);
    sc.AddItem(food2);
    sc.AddItem(food3);

    Console.WriteLine(sc.CalculateTotal().ToString());

    sc.RemoveItem(food1);

    Console.WriteLine(sc.CalculateTotal().ToString());
}
catch (FoodNotFoundException ex)
{
    Console.WriteLine(ex.Message); 
}
