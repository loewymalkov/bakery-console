namespace Bakery
{
  class Bread
  {
    private string _name;
    private int _price;

    private int _quantity;

    public Bread(string name, int price, int quantity)
    {
      _name = name;
      _price = price;
      _quantity = quantity;
    }

    public string GetName()
    {
      return _name;
    }


    public int GetPrice()
    {
      return _price;
    }

    public int GetQuantity()
    {
      return _quantity;
    }

    public void SetAddOne()
    {
      _quantity += 1;
    }

  }

  class Pastery
  {
    private string _name;
    private int _price;
    private int _quantity;

    public Pastery(string name, int price, int quantity)
    {
      _name = name;
      _price = price;
      _quantity = quantity;
    }

    public string GetName()
    {
      return _name;
    }


    public int GetPrice()
    {
      return _price;
    }

    public int GetQuantity()
    {
      return _quantity;
    }

    public void SetAddOne()
    {
      _quantity += 1;
    }
  }
}