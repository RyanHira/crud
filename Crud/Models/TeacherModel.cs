﻿namespace Crud.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<CourseModel>? Courses { get; set; }

    }
}
