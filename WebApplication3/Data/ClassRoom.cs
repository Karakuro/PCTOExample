namespace WebApplication3.Data
{
    public class ClassRoom
    {
        public int ClassRoomId { get; set; }
        public required string Description { get; set; }
        public List<Student>? Students { get; set; }
    }
}
