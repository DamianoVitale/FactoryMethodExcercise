// See https://aka.ms/new-console-template for more information
using Esercizio1.Library;

var food1 = FoodFactory.Get("fruit", "Apple", 1.10);
var food2 = FoodFactory.Get("vegetables", "carrot ", 0.70);
var food3 = FoodFactory.Get("meat", "hamburger ", 2.52);
food3.DisplayInfo();
food2.DisplayInfo();
food1.DisplayInfo();
