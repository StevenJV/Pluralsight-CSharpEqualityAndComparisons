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

    public string Name => _name;

    public Food(string name)
    {
      _name = name;
    }

    public override string ToString()
    {
      return _name;
    }
  }
}