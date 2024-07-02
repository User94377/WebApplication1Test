namespace WebApplication1Test.Models
{
    public class Master
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Task>? Tasks { get; set; }
    }
}
