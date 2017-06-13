using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
  public enum FoodGroup { Meat, Fruit, Vegetables, Sweets}
  struct FoodItem
  {
    private readonly string _name;
    private readonly FoodGroup _group;

    public string Name => _name;
    public FoodGroup Group => _group;

    public FoodItem(string name, FoodGroup group)
    {
      this._name = name;
      this._group = group;
    }

    public override string ToString()
    {
      return _name;
    }

  }
}
