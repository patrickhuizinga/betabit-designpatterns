using System;
using System.Runtime.Serialization;

namespace BetaBit.DesignPatterns
{
    [DataContract]
    public sealed class ClaimId : IEquatable<ClaimId>
    {
        [DataMember] public string Value { get; }

        public ClaimId(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (value.Length != 10) throw new ArgumentException("ClaimId must be exactly 10 long.", nameof(value));

            Value = value;
        }

        // post serialization validation left as an exercise to the reader

        public override bool Equals(object obj) => Equals(obj as ClaimId);

        public bool Equals(ClaimId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(ClaimId left, ClaimId right) => Equals(left, right);

        public static bool operator !=(ClaimId left, ClaimId right) => !Equals(left, right);

        public override string ToString() => Value;
    }
}
