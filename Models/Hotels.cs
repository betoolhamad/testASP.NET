
namespace Myexam.Models;

public class Hotels {

    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }


    public decimal Price { get; set; }

    public string City { get; set; }

    public string Location { get; set; }

    public string Images { get; set; }

    public List<string> Facility { get; set; } = new List<string>(); //تفاصيل الفندق

}