using System;

namespace AngryWasp.Math
{
    public struct Range
    {
        public static readonly Range Zero = new Range(0f, 0f);

        public float Minimum;

        public float Maximum;

        public float Size => this.Maximum - this.Minimum;

        public Range(Range a)
        {
            this.Minimum = a.Minimum;
            this.Maximum = a.Maximum;
        }

        public Range(float Minimum, float Maximum)
        {
            this.Minimum = Minimum;
            this.Maximum = Maximum;
        }

        public static void Divide(float s, ref Range v, out Range result) => result = new Range(s / v.Minimum, s / v.Maximum);

        public static void Divide(ref Range v, float s, out Range result)
        {
            float num = 1f / s;
            result = new Range(v.Minimum * num, v.Maximum * num);
        }

        public static Range Divide(Range v, float s)
        {
            float num = 1f / s;
            return new Range(v.Minimum * num, v.Maximum * num);
        }

        public static Range Divide(float s, Range v) => new Range(s / v.Minimum, s / v.Maximum);

        public static void Multiply(float s, ref Range v, out Range result) => result = new Range(s * v.Minimum, s * v.Maximum);

        public static void Multiply(ref Range v, float s, out Range result) => result = new Range(s * v.Minimum, s * v.Maximum);

        public static Range Multiply(float s, Range v) => new Range(s * v.Minimum, s * v.Maximum);

        public static Range Multiply(Range v, float s) => new Range(s * v.Minimum, s * v.Maximum);

        public static void Negate(ref Range v, out Range result) => result = new Range(-v.Minimum, -v.Maximum);

        public static Range Negate(Range v) => new Range(-v.Minimum, -v.Maximum);

        public bool Equals(Range v, float epsilon) => MathF.Abs(this.Minimum - v.Minimum) <= epsilon && MathF.Abs(this.Maximum - v.Maximum) <= epsilon;

        public override bool Equals(object obj) => obj is Range && this == (Range)obj;

        public override int GetHashCode() => this.Minimum.GetHashCode() ^ this.Maximum.GetHashCode();

        public string ToString(int precision)
        {
            string text = "";
            text = text.PadLeft(precision, '#');
            text = string.Concat(new string[] {
                "{0:0.",
                text,
                "} {1:0.",
                text,
                "}"
            });
            return string.Format(text, this.Minimum, this.Maximum);
        }

        public override string ToString() => $"{this.Minimum} {this.Maximum}";

        //
        // Operators
        //
        public static Range operator /(Range v, float s)
        {
            float num = 1f / s;
            return new Range(v.Minimum * num, v.Maximum * num);
        }

        public static Range operator /(float s, Range v) => new Range(s / v.Minimum, s / v.Maximum);

        public static bool operator ==(Range v1, Range v2) => v1.Minimum == v2.Minimum && v1.Maximum == v2.Maximum;

        public static bool operator !=(Range v1, Range v2) => v1.Minimum != v2.Minimum || v1.Maximum != v2.Maximum;

        public static Range operator *(float s, Range v) => new Range(s * v.Minimum, s * v.Maximum);

        public static Range operator *(Range v, float s) => new Range(s * v.Minimum, s * v.Maximum);

        public static Range operator -(Range v) => new Range(-v.Minimum, -v.Maximum);
    }
}