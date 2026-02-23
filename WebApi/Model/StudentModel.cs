using System.ComponentModel.DataAnnotations;

namespace WebApi.Model
{
    public class StudentModel
    {
        [Key]
        public int id { get; set; }
        public string studentName { get; set; }
        public string studentAddress { get; set; }

    }
}
