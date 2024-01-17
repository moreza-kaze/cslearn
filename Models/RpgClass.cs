using System.Text.Json.Serialization;

namespace test3.Models
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum RpgClass
  {
    holo = 1,
    sib = 2,
    kivi = 3,
  }
}