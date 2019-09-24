using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lightStore_API.Models
{
  public class Product
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    [JsonIgnore]
    public Category Category { get; set; }
  }
}
