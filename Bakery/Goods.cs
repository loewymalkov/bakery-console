namespace Bakery
{
  public class Bread
  {
    public string Name { get; set; } = "loaf";
    public double Price { get; set; } = 4;
    public double Quantity { get; set; } = 0;
    public int Breakpoint { get; set; } = 2;
    public double Total { get; set; }

     public void CalculatePrice()
    {
      Total = CalculateMax() - GetDiscount();
    }

    public double CalculateMax()
    {
      return (Price * Quantity);
    }

    public double GetDiscount()
  {
    return (Quantity/Breakpoint) * Price;
  }


    public void AddOne()
    {
      Quantity += 1;
    }
  }

  public class Pastery
  {
    public string Name { get; set; } = "croissant";
    public double Price { get; set; } = 2;
    public double Quantity { get; set; } = 0;
    public int Breakpoint { get; set; } = 3;
    public double Total { get; set; }

     public void CalculatePrice()
    {
      Total = CalculateMax() - GetDiscount();
    }

    public double CalculateMax()
    {
      return (Price * Quantity);
    }

    public double GetDiscount()
  {
    return (Quantity/Breakpoint) * Price;
  }

    public void AddOne()
    {
      Quantity += 1;
    }
  }
}