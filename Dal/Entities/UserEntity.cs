using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dal.Entities
{
    public class UserEntity : IEntity
    {
        public UserEntity()
        {
            Photos = new List<PhotoEntity>();
            Posts = new List<PostEntity>();
            Friends = new List<FriendsEntity>();
            IsRelated = new List<FriendsEntity>();
        }

        [Key,Required]
        public int Id { get; set; }
        public string UserIdentificator { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime JoinDate { get; set; }
        public string Gender { get; set; }
        public string Mail { get; set; }

        public List<PhotoEntity> Photos { get; set; }
        public List<PostEntity> Posts { get; set; }
        public List<FriendsEntity> Friends { get; set; }
        public List<FriendsEntity> IsRelated { get; set; }
    }
}
