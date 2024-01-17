namespace test3.Models
{
  public class Character
  {
    public int Id { get; set; } = 0 ;
    public string Name { get; set; } = "Amir" ;

    public RpgClass Mmd{ get; set; } = RpgClass.holo;
  }
}