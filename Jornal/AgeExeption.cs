using System;
using System.Runtime.Serialization;

namespace Jornal
{
    public class AgeExeption : ArgumentException
    {
        public int Value { get; }
        public AgeExeption(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
}