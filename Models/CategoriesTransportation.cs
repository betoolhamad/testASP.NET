using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Myexam.Models;

public class CategoriesTransportation {
    [Key]

    public int Id { get; set; }

    public string Name { get; set; } //seedan jeeb small

}
