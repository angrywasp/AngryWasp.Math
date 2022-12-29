using System;

namespace AngryWasp.Math
{
    public struct Degree : IComparable<Degree>, IComparable<float>
    {
        public const float ToRadCoefficient = MathF.PI / 180.0f;

        public static readonly Degree Zero = new Degree(0f);

        private float val;

        public Degree(float r) => this.val = r;

        public Degree(int r) => this.val = (float)r;

        public Degree(Degree d) => this.val = d.val;

        public Degree(Radian r) => this.val = r.ToDegrees();

        public static Degree Parse(string text) => new Degree(float.Parse(text));

        public int CompareTo(float other) => this.val.CompareTo(other);

        public int CompareTo(Radian other) => this.val.CompareTo(other.ToDegrees());

        public int CompareTo(Degree other) => this.val.CompareTo(other);

        public override bool Equals(object obj) => obj is Degree && this == (Degree)obj;

        public override int GetHashCode() => this.val.GetHashCode();

        public Radian ToRadians() => this.val * ToRadCoefficient;

        public override string ToString() => this.val.ToString("0.0######");

        public static Degree operator +(Degree left, Radian right) => left + right.ToDegrees();

        public static Degree operator +(Degree left, int right) => left.val + (float)right;

        public static Degree operator +(Degree left, float right) => left.val + right;

        public static Degree operator +(Degree left, Degree right) => left.val + right.val;

        public static Degree operator /(Degree left, float right) => left.val / right;

        public static bool operator ==(Degree left, Degree right) => left.val == right.val;

        public static bool operator >(Degree left, Degree right) => left.val > right.val;

        public static implicit operator Degree(float value) => new Degree(value);

        public static implicit operator Degree(int value) => new Degree((float)value);

        public static implicit operator Degree(Radian value) => new Degree(value);

        public static implicit operator float(Degree value) => value.val;

        public static bool operator !=(Degree left, Degree right) => left.val != right.val;

        public static bool operator <(Degree left, Degree right) => left.val < right.val;

        public static Degree operator *(Degree left, Radian right) => left.val * right.ToDegrees();

        public static Degree operator *(int left, Degree right) => (float)left * right.val;

        public static Degree operator *(float left, Degree right) => left * right.val;

        public static Degree operator *(Degree left, int right) => left.val * (float)right;

        public static Degree operator *(Degree left, float right) => left.val * right;

        public static Degree operator *(Degree left, Degree right) => left.val * right.val;

        public static Degree operator -(Degree left, Radian right) => left - right.ToDegrees();

        public static Degree operator -(Degree left, int right) => left.val - (float)right;

        public static Degree operator -(Degree left, float right) => left.val - right;

        public static Degree operator -(Degree left, Degree right) => left.val - right.val;

        public static Degree operator -(Degree r) => -r.val;
    }
}
