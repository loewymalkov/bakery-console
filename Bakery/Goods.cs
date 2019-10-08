namespace Bakery
{
  public class Bread
  {
    public string Name { get; set; } = "loaf";
    public double Price { get; set; } = 4;
    public double Quantity { get; set; } = 0;
    private double _total { get; set; } = 0;
    public double Total 
    { 
      get {return _total;}
      set {_total = this.Price * this.Quantity;}
    }

    public void AddOne()
    {
      Quantity += 1;
    }

    public double Deal()
    {
      if (Quantity >= 2)
      {
        double newTotal = Total - 4;
        return newTotal;
      }
      else
      {
        return Total;
      }
    }

  }

  public class Pastery
  {
    public string Name { get; set; } = "croissant";
    public double Price { get; set; } = 2;
    public double Quantity { get; set; } = 0;
    private double _total { get; set; } = 0;
    public double Total 
    { 
      get {return _total;}
      set {_total = this.Price * this.Quantity;}
    }

    public void AddOne()
    {
      Quantity += 1;
    }

    public double Deal()
    {
      if (Quantity >= 3)
      {
        double threeForFive = Total - 1;
        return threeForFive;
      }
      else
      {
        return Total;
      }
    }
  }
}