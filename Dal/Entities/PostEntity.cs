using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static Helpers.Models.Enums.Definitions;

namespace Dal.Entities
{
    public class PostEntity : IEntity
    {
        [Key,Required]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public Visibility VisibilityType { get; set; }

        public UserEntity User { get; set; }
    }
}
