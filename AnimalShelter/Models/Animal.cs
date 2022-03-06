namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public string Date_Admitted { get ; set; } // Date
    public string Breed { get; set; }

    // public static List<Animal> SortAnimals()
    // {
    //   foreach(Animal animal in )
    // }
  }

}