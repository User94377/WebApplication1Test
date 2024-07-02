using System.Text.Json.Serialization;

namespace WebApplication1Test.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }


        public int? MasterId { get; set; }

        public Master? Master { get; set; }
    }
}
