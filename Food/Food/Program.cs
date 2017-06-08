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
      Food chocolate = new Food("chocolate");

      Console.WriteLine($"Banana.Equals(chocolate) ? {banana.Equals(chocolate)}");
  }
  }
}
