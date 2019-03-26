using System;
using System.Runtime.Serialization;

namespace Jornal
{
    public class BirthdayExeption : ArgumentException
    {
        public int Value { get; }
        public BirthdayExeption(string message, int val)
            : base(message)
        {
            Value = val;
        }
    }
}