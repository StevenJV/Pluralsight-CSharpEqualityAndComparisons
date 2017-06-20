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
  }
}