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
      Food banana = new Food("banana");
      Food banana2 = new Food("banana");
      Food chocolate = new Food("chocolate");

      Console.WriteLine($"Banana.Equals(chocolate) ? {banana.Equals(chocolate)}");
      Console.WriteLine($"Banana.Equals(banana2) ? {banana.Equals(banana2)} // false because object.Equals() asks 'is this the same instance?'");
      Console.WriteLine($"Banana.Equals(null) ? {banana.Equals(null)}  // null NEVER equals any non-null reference");
      Food noBanana = null;
      //Console.WriteLine($"noBanana.Equals(Banana) ? {noBanana.Equals(banana)}  // run-time exception");
      Console.WriteLine($"object.Equals(banana, noBanana) ? {object.Equals(banana, noBanana)}  // null NEVER equals any non-null reference, no run-time exception"); 
      Console.WriteLine($"object.Equals(null, noBanana) ? {object.Equals(null, noBanana)}  // null always equals null");

      string bananaStr = "banana";
      string copyOfBananaStr = string.Copy(bananaStr);

      Console.WriteLine($"BananaStr.Equals((object)copyOfBananaStr) ? {bananaStr.Equals((object)copyOfBananaStr)} // string.Equals looks at contnets, treating strings like values rather than references ");
      Console.WriteLine($"ReferenceEquals(bananaStr,copyOfBananaStr) ? {ReferenceEquals(bananaStr,copyOfBananaStr)} // ReferenceEquals checks for two pointers to the same object ");


      Console.WriteLine("\n--- overloaded Equals() and == ");

      FoodItem redDelicious = new FoodItem("apple", FoodGroup.Fruit);
      FoodItem grannySmith = new FoodItem("apple", FoodGroup.Fruit);
      FoodItem cake = new FoodItem("birthday", FoodGroup.Sweets);

      Console.WriteLine($"redDelicious ==   grannySmith : "+(redDelicious == grannySmith));
      Console.WriteLine($"grannySmith  ==   cake        : " +(grannySmith == cake));
      Console.WriteLine($"cake         ==   redDelicious: " +(cake == redDelicious));

    }
  }
}
