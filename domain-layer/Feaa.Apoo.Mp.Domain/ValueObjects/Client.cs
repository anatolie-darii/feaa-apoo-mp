using System;

namespace Feaa.Apoo.Mp.Domain.ValueObjects {
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}