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

      string bananaStr = "banana";
      string copyOfBananaStr = string.Copy(bananaStr);

      Console.WriteLine($"BananaStr.Equals((object)copyOfBananaStr) ? {bananaStr.Equals((object)copyOfBananaStr)} // string.Equals looks at contnets, treating strings like values rather than references");


    }
  }
}
