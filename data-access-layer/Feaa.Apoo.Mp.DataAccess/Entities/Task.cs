using System;

namespace Feaa.Apoo.Mp.DataAccess.Entities
{
    public class Task
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public ExecutionState State { get; set; }

        public virtual Project Project { get; set; }
    }
}