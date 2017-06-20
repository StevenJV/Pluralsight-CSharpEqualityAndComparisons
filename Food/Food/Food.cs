// example of overriding equality for REFERENCE TYPES

using System.Diagnostics.Eventing.Reader;

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

    //think very carefully before overloading Reference types, it's not often something you really want to do.
    public override bool Equals(object obj)
    {
      if (obj == null)
        return false;
      if (ReferenceEquals(obj, this)) // they point to the same instance
        return true;
      if (obj.GetType() != this.GetType())
        return false;
      Food rhs = obj as Food;
      return _name == rhs._name && this._group == rhs._group;
    }

    public override int GetHashCode()
    {
      return this._name.GetHashCode() ^ this._group.GetHashCode();
    }

    public static bool operator ==(Food x, Food y){
      return object.Equals(x, y);
      // don't do this. Base class has no idea if we're really in a derived class
      // return x._name == y._name && x._group == y._group
    }

    public static bool operator !=(Food x, Food y){
      return !object.Equals(x, y);
    }
  }
}