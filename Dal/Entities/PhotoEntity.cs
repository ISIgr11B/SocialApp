using System;
using System.ComponentModel.DataAnnotations;
using static Helpers.Models.Enums.Definitions;

namespace Dal.Entities
{
    public class PhotoEntity : IEntity
    {
        [Key, Required]
        public int Id { get; set; }
        public string Path { get; set; }
        public int UserId { get; set; }
        public DateTime UploadDate { get; set; }
        public Visibility Visibility { get; set; }

        public UserEntity User { get; set; }
    }
}
