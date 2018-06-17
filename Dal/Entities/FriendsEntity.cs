using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static Helpers.Models.Enums.Definitions;

namespace Dal.Entities
{
    public class FriendsEntity : IEntity
    {
        [Key,Required]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RelativeUserId { get; set; }
        public FriendType Type { get; set; }

        public UserEntity User { get; set; }
        public UserEntity RelativeUser { get; set; }

        public FriendsEntity()
        {
            User = new UserEntity();
            RelativeUser = new UserEntity();
        }
    }
}
