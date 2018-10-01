using System;
using System.Collections.Generic;

namespace Feaa.Apoo.Mp.DataAccess.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProjectType Type { get; set; }
        public ExecutionState State { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public string ClientId { get; set; }

        public virtual Client Client { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}