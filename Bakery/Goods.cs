namespace Bakery
{
  public class Bread
  {
    private string _name;
    private double _price;
    private double _quantity;
    private double _total;

    public Bread(string name, double price, double quantity, double total)
    {
      _name = name;
      _price = price;
      _quantity = quantity;
      _total = total;
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
    public double GetTotal()
    {
      return _total;
    }
    public void SetAddOne()
    {
      _quantity += 1;
    }

    public void SetTotal()
    {
      _total = GetPrice() * GetQuantity();
    }

    public double SetDeal()
    {
      if (GetQuantity() >= 2)
      {
        double newTotal = _total/2;
        return newTotal;
      }
      else
      {
        double newTotal = _total;
        return newTotal;
      }
    }

  }

  public class Pastery
  {
    private string _name;
    private double _price;
    private double _quantity;
    private double _total;

    public Pastery(string name, double price, double quantity, double total)
    {
      _name = name;
      _price = price;
      _quantity = quantity;
      _total = total;
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

    public double GetTotal()
    {
      return _total;
    }

    public void SetAddOne()
    {
      _quantity += 1;
    }

    public void SetTotal()
    {
      _total = GetPrice() * GetQuantity();
    }

    public double SetDeal()
    {
      if (GetQuantity() >= 3)
      {
        double threeForFive = _total - 1;
        return threeForFive;
      }
      else
      {
        double normalPrice = _total;
        return normalPrice;
      }
    }
  }
}