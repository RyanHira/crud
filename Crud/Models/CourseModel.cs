namespace Crud.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public List<TeacherModel>? Teachers { get; set; }
        public List<StudentModel>? Students { get; set; }
    }
}
