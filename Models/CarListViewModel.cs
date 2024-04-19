namespace Lab_FormSubmit_ListData.Models
{
    public class Car
    {
        public string? Name { get; set; }
    }

    public class CarListViewModel
    {
        public List<Car>? CarList { get; set; }
    }
}