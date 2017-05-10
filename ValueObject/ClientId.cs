using System;
using System.Runtime.Serialization;

namespace BetaBit.DesignPatterns
{
    [DataContract]
    public sealed class ClientId : IEquatable<ClientId>
    {
        [DataMember] public string Value { get; }

        public ClientId(string value)
        {
            if (value == null) throw new ArgumentNullException(nameof(value));
            if (value.Length != 9) throw new ArgumentException("ClientId must be exactly 9 long.", nameof(value));
            // perform digit check

            Value = value;
        }

        // post serialization validation left as an exercise to the reader

        public override bool Equals(object obj) => Equals(obj as ClientId);

        public bool Equals(ClientId other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Value, other.Value);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public static bool operator ==(ClientId left, ClientId right) => Equals(left, right);

        public static bool operator !=(ClientId left, ClientId right) => !Equals(left, right);

        public override string ToString() => Value;
    }
}
