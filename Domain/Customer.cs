using System;
using Interfaces;

namespace Domain
{
    public class Customer : IKey<Guid>
    {
        public Guid Key { get; }
    }
}