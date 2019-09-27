namespace Bakery
{
  public class Bread
  {
    private string _name;
    private double _price;

    private double _quantity;

    public Bread(string name, double price, double quantity)
    {
      _name = name;
      _price = price;
      _quantity = quantity;
    }

    public string GetName()
    {
      return _name;
    }


    public double GetPrice()
    {
      return _price;
    }

    public double GetQuantity()
    {
      return _quantity;
    }

    public void SetAddOne()
    {
      _quantity += 1;
    }

    public void SetDeal()
    {
      if (GetQuantity() >= 2)
      {
        _price = (_price/2);
      }
    }

  }

  public class Pastery
  {
    private string _name;
    private double _price;
    private double _quantity;

    public Pastery(string name, double price, double quantity)
    {
      _name = name;
      _price = price;
      _quantity = quantity;
    }

    public string GetName()
    {
      return _name;
    }


    public double GetPrice()
    {
      return _price;
    }

    public double GetQuantity()
    {
      return _quantity;
    }

    public void SetAddOne()
    {
      _quantity += 1;
    }

    public void SetDeal()
    {
      if (GetQuantity() >= 3)
      {
        _price = 5;
      }
    }
  }
}