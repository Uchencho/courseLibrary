﻿namespace CourseLibrary.API.Models
{
    public class AuthorForCreationDTO
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MainCategory { get; set; } = string.Empty;
        public DateTimeOffset DateOfBirth { get; set; }
        public ICollection<CourseForCreationDto> Courses { get; set; } = new List<CourseForCreationDto>();
    }
}
