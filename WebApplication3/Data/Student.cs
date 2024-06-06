using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string FiscalCode { get; set; }
        public int ClassRoomId { get; set; }
        public ClassRoom? ClassRoom { get; set; }
    }
}
