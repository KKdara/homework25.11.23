using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework25._11._23
{
    [DeveloperInfoAttribute("Tom", "05.06.2020")]
    public class RationalNumber
    {
        protected int numerator;
        protected int denominator;

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator can't be equal to 0.");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            RationalNumber other = (RationalNumber)obj;
            return (numerator == other.numerator && denominator == other.denominator);
        }
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a == b;
        }
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a < b;
        }
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a > b;
        }
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a < b || a == b;
        }
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a > b || a == b;
        }
        public static RationalNumber operator +(RationalNumber a, RationalNumber b)
        {
            int common_denominator;
            int new_numerator;
            if (a.denominator == b.denominator)
            {
                common_denominator = a.denominator;
                new_numerator = a.numerator + b.numerator;
            }
            else
            {
                common_denominator = a.numerator * b.denominator;
                new_numerator = (a.numerator * b.denominator) + (b.numerator * a.denominator);
            }
            return new RationalNumber(new_numerator, common_denominator);
        }
        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int common_denominator;
            int new_numerator;
            if (a.denominator == b.denominator)
            {
                common_denominator = a.denominator;
                new_numerator = a.numerator - b.numerator;
            }
            else
            {
                common_denominator = a.numerator * b.denominator;
                new_numerator = (a.numerator * b.denominator) - (b.numerator * a.denominator);
            }
            return new RationalNumber(new_numerator, common_denominator);
        }
        public static RationalNumber operator ++(RationalNumber a)
        {
            return new RationalNumber(a.numerator + 1, a.denominator + 1);
        }
        public static RationalNumber operator --(RationalNumber a)
        {
            return new RationalNumber(a.numerator - 1, a.denominator - 1);
        }
        public static RationalNumber operator *(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.numerator, a.denominator * b.denominator);
        }
        public static RationalNumber operator /(RationalNumber a, RationalNumber b)
        {
            return new RationalNumber(a.numerator * b.denominator, a.denominator * b.numerator);
        }
        public static RationalNumber operator %(RationalNumber a, RationalNumber b)
        {
            int q = (a.numerator * b.denominator) / (a.denominator * b.numerator);
            return new RationalNumber(a.numerator + b.numerator * q, a.denominator);
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
        public static implicit operator int(RationalNumber a)
        {
            return a.numerator / a.denominator;
        }
        public static implicit operator float(RationalNumber a)
        {
            return a.numerator / a.denominator;
        }
    }
}
