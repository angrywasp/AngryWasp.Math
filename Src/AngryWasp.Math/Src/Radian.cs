using System;

namespace AngryWasp.Math
{
    public struct Radian : IComparable<float>, IComparable<Radian>
    {
        public const float ToDegCoefficient = 180.0f / MathF.PI;

        public static readonly Radian Zero = new Radian(0f);

        private float val;

        public Radian(float r) => this.val = r;

        public Radian(int r) => this.val = (float)r;

        public Radian(Radian r) => this.val = r.val;

        public Radian(Degree d) => this.val = d.ToRadians();

        public static Radian Parse(string text) => new Radian(float.Parse(text));

        public int CompareTo(float other) => this.val.CompareTo(other);

        public int CompareTo(Degree other) => this.val.CompareTo(other.ToRadians());

        public int CompareTo(Radian other) => this.val.CompareTo(other.val);

        public override bool Equals(object obj) => obj is Radian && this == (Radian)obj;

        public override int GetHashCode() => this.val.GetHashCode();

        public Degree ToDegrees() => this.val * ToDegCoefficient;

        public override string ToString() => this.val.ToString("0.0######");

        public static Radian operator +(Radian left, Degree right) => left + right.ToRadians();

        public static Radian operator +(Radian left, int right) => left.val + (float)right;

        public static Radian operator +(Radian left, float right) => left.val + right;

        public static Radian operator +(Radian left, Radian right) => left.val + right.val;

        public static Radian operator /(Radian left, float right) => left.val / right;

        public static bool operator ==(Radian left, Radian right) => left.val == right.val;

        public static bool operator >(Radian left, Radian right) => left.val > right.val;

        public static implicit operator Radian(float value) => new Radian(value);

        public static implicit operator Radian(int value) => new Radian((float)value);

        public static implicit operator Radian(Degree value) => new Radian(value);

        public static implicit operator float(Radian value) => value.val;

        public static bool operator !=(Radian left, Radian right) => left.val != right.val;

        public static bool operator <(Radian left, Radian right) => left.val < right.val;

        public static Radian operator *(Radian left, Degree right) => left.val * right.ToRadians();

        public static Radian operator *(int left, Radian right) => (float)left * right.val;

        public static Radian operator *(float left, Radian right) => left * right.val;

        public static Radian operator *(Radian left, int right) => left.val * (float)right;

        public static Radian operator *(Radian left, float right) => left.val * right;

        public static Radian operator *(Radian left, Radian right) => left.val * right.val;

        public static Radian operator -(Radian left, Degree right) => left - right.ToRadians();

        public static Radian operator -(Radian left, int right) => left.val - (float)right;

        public static Radian operator -(Radian left, float right) => left.val - right;

        public static Radian operator -(Radian left, Radian right) => left.val - right.val;

        public static Radian operator -(Radian r) => -r.val;
    }
}
