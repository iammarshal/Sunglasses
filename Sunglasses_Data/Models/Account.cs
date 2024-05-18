using System;
using System.Collections.Generic;

#nullable disable

namespace Sunglasses_Repository.Models
{
    public partial class Account
    {
        public int MemberAccountId { get; set; }
        public string MemberAccountPassword { get; set; }
        public string MemberFullName { get; set; }
        public string MemberEmail { get; set; }
        public int? Role { get; set; }
    }
}
