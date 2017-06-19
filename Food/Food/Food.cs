// example of overriding equality for REFERNCE TYPES

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
  public class Food
  {
    private readonly string _name;
    private readonly FoodGroup _group;

    public string Name => _name;
    public FoodGroup Group => _group;

    public Food(string name, FoodGroup group)
    {
      _name = name;
      _group = group;
    }

    public override string ToString()
    {
      return _name;
    }
  }
}