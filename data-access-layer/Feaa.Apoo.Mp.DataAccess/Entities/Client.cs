using System;
using System.Collections.Generic;

namespace Feaa.Apoo.Mp.DataAccess.Entities {
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}