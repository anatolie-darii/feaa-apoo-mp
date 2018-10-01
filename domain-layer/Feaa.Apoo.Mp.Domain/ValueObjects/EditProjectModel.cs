using System;

namespace Feaa.Apoo.Mp.Domain.ValueObjects {
    public class EditProjectModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ProjectType Type { get; set; }
        public ExecutionState State { get; set; }
        public DateTime StartDate { get; set; }
    }
}