using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPracticalExercise.Models
{
    public partial class Quote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Tickets { get; private set; }
        public string Coverage { get; set; }

    }
}