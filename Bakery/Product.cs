namespace Bakery
{
  class Bread
  {
    private string _name;
    private int _price;

    public Bread(string name, int price)
    {
      _name = name;
      _price = price;
    }

    public string GetName()
    {
      return _name;
    }


    public int GetPrice()
    {
      return _price;
    }

  }

  class Pastery
  {
    private string _name;
    private int _price;

    public Pastery(string name, int price)
    {
      _name = name;
      _price = price;
    }
  }
}