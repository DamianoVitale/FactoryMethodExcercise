namespace Esercizio1.Library
{
    public static class FoodFactory
    {
        public static IFood Get(FoodEnum type, string name, double price) => type switch
        {

            
            FoodEnum.Vegetable => new Vegetables(name, price),
            FoodEnum.Fruit => new Fruit(name, price),
            FoodEnum.Meat => new Meat(name, price),
            _ => throw new FoodNotFoundException(type)
        };
    }
}
