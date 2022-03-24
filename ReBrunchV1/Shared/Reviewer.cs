using System;
using System.Collections.Generic;
using System.Text;

namespace ReBrunchV1.Shared
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public DateTime? JoinedDate { get; set; }
        public int ReviewerCategoryId { get; set; }
    }
}
