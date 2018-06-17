using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers.Models.Enums
{
    public class Definitions
    {
        public enum Visibility
        {
            PUBLIC,
            PRIVATE,
            FRIENDS,
            FRIENDSOFFIRENDS
        }

        public enum FriendType
        {
            PENDING,
            FRIENDS,
            BLOCKING,
            REMOVED
        }
    }
}
