using System;
namespace API_GrupoFleury.models
{
  public class Address
  {
    public int Id { get; set; }
    public String Street { get; set; }
    public int Number { get; set; }
    public String District { get; set; }
    public String ZipCode { get; set; }
    public String City { get; set; }
  }
}