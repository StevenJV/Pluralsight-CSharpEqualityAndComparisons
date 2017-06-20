using System.Net.Configuration;

namespace Food
{
  public sealed class CookedFood : Food
  {
    private readonly string _cookingMethod;
    public string CookingMethod => _cookingMethod;

    public CookedFood(string cookingMethod, string name, FoodGroup group) : base(name, group){
      this._cookingMethod = cookingMethod;
    }

    public override string ToString(){
      return string.Format($"{_cookingMethod} {Name}");
    }

    public override bool Equals(object obj){
      if (!base.Equals(obj))
        // base class checks for null, same instance, and its own fields
        return false;
      // only need to check derived class fields
      CookedFood rhs = (CookedFood) obj;
      return _cookingMethod == rhs._cookingMethod;
    }

    public override int GetHashCode(){
      return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
    }

    public static bool operator ==(CookedFood x, CookedFood y){
      return object.Equals(x, y);
    }

    public static bool operator !=(CookedFood x, CookedFood y){
      return !object.Equals(x, y);
    }
  }
}