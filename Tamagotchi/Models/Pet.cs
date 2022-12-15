namespace Tamagotchi.Models
{
  public class Pet 
  {
    public string Name { get; set; }
    public int Food { get; set; }
    public int Happiness { get; set; }
    public int Sleep { get; set; }
    private static List<Pet> _instances = new List<Pet> { };

    public Pet(string name)
    {
      Name = name;
      Food = 20;
      Happiness = 50;
      Sleep = 30;
      _instances.Add(this);
    }

    public static List<Pet> GetAll()
    {
     return _instances;
    }

    public static Pet Find(string name)
    {
      Pet foundPet = _instances[0];
      for (int i = 0; i < _instances.Count; i++)
      {
        if (_instances[i].Name == name)
        {
          foundPet = _instances[i];
          break;
        }
      }
      return foundPet;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void Feed(string petName)
    {
      foreach(Pet pet in _instances)
      {
        if (pet.Name == petName)
        {
          pet.Food += 10;
          pet.Happiness += 5;
          pet.Sleep -= 5;
        }
        else
        {
          pet.Food -= 10;
          pet.Happiness -= 10;
          pet.Sleep -= 10;
        }
      }
    }

    public static void Nap(string petName)
    {
      foreach(Pet pet in _instances)
      {
        if (pet.Name == petName)
        {
          pet.Food -= 10;
          pet.Happiness -= 10;
          pet.Sleep += 20;
        }
        else
        {
          pet.Food -= 10;
          pet.Happiness -= 10;
          pet.Sleep -= 10;
        }
      }
    }

    public static void Play(string petName)
    {
      foreach(Pet pet in _instances)
      {
        if (pet.Name == petName)
        {
          pet.Food -= 10;
          pet.Happiness += 15;
          pet.Sleep -= 10;
        }
        else
        {
          pet.Food -= 10;
          pet.Happiness -= 10;
          pet.Sleep -= 10;
        }
      }
    }
  }
}