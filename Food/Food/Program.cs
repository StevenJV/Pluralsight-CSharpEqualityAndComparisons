using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
  class Program
  {
    static void Main(string[] args)
    {
      Food banana = new Food("banana", FoodGroup.Fruit);
      Food banana2 = new Food("banana", FoodGroup.Fruit);
      Food chocolate = new Food("chocolate", FoodGroup.Sweets);

      Console.WriteLine($"Banana.Equals(chocolate) ? {banana.Equals(chocolate)}");
      Console.WriteLine(
        $"Banana.Equals(banana2) ? {banana.Equals(banana2)} // false because object.Equals() asks 'is this the same instance?'");
      Console.WriteLine($"Banana.Equals(null) ? {banana.Equals(null)}  // null NEVER equals any non-null reference");
      Food noBanana = null;
      //Console.WriteLine($"noBanana.Equals(Banana) ? {noBanana.Equals(banana)}  // run-time exception");
      Console.WriteLine(
        $"object.Equals(banana, noBanana) ? {object.Equals(banana, noBanana)}  // null NEVER equals any non-null reference, no run-time exception");
      Console.WriteLine($"object.Equals(null, noBanana) ? {object.Equals(null, noBanana)}  // null always equals null");

      string bananaStr = "banana";
      string copyOfBananaStr = string.Copy(bananaStr);

      Console.WriteLine(
        $"BananaStr.Equals((object)copyOfBananaStr) ? {bananaStr.Equals((object) copyOfBananaStr)} // string.Equals looks at contnets, treating strings like values rather than references ");
      Console.WriteLine(
        $"ReferenceEquals(bananaStr,copyOfBananaStr) ? {ReferenceEquals(bananaStr, copyOfBananaStr)} // ReferenceEquals checks for two pointers to the same object ");


      Console.WriteLine("\n--- overloaded Equals() and == for Value Types");

      FoodItem redDelicious = new FoodItem("apple", FoodGroup.Fruit);
      FoodItem grannySmith = new FoodItem("apple", FoodGroup.Fruit);
      FoodItem cake = new FoodItem("birthday", FoodGroup.Sweets);

      Console.WriteLine($"redDelicious ==   grannySmith : " + (redDelicious == grannySmith));
      Console.WriteLine($"grannySmith  ==   cake        : " + (grannySmith == cake));
      Console.WriteLine($"cake         ==   redDelicious: " + (cake == redDelicious));

      Console.WriteLine("redDelicious.Equals(grannySmith): " + redDelicious.Equals(grannySmith));
      Console.WriteLine("grannySmith.Equals(cake)        : " + grannySmith.Equals(cake));
      Console.WriteLine("cake.Equals(redDelicious)       : " + cake.Equals(redDelicious));

      Console.WriteLine("\n--- overloaded Equals() and == for Reference Types");
      Food apple = new Food("apple", FoodGroup.Fruit);
      CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
      CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
      CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);
      Food apple2 = new Food("apple", FoodGroup.Fruit);

      DisplayWhetherEqueal(apple, stewedApple);
      DisplayWhetherEqueal(stewedApple, bakedApple);
      DisplayWhetherEqueal(stewedApple, stewedApple2);
      DisplayWhetherEqueal(apple, apple2);
      DisplayWhetherEqueal(apple, apple);
    }

    private static void DisplayWhetherEqueal(Food food1, Food food2)
    {
      Console.WriteLine(food1 == food2 ? $"{food1,12} == {food2}" : $"{food1,12} != {food2}");
    }
  }
}