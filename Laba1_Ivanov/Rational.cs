using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Laba1_Ivanov
{
    public class Rational
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }

            int gcd = GCD(numerator, denominator);
            Numerator = numerator / gcd;
            Denominator = denominator / gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }
        public override string ToString()
        {
            if (this.Denominator == 1 || this.Denominator == -1 || this.Numerator == 0)
            {
                return Convert.ToString(this.Numerator / this.Denominator);
            }
            if ((this.Numerator < 0 && this.Denominator > 0) || (this.Numerator > 0 && this.Denominator < 0))
            {
                return "-" + Convert.ToString(Abs(this.Numerator)) + "/" + Convert.ToString(Abs(this.Denominator));
            }
            return Convert.ToString((this.Numerator) + "/" + Convert.ToString(this.Denominator));
        }
        public static Rational operator +(Rational lhs, Rational rhs)
        {
            return new Rational(lhs.Numerator * rhs.Denominator + rhs.Numerator * lhs.Denominator,
                                lhs.Denominator * rhs.Denominator);
        }

        public static Rational operator -(Rational lhs, Rational rhs)
        {
            return new Rational(lhs.Numerator * rhs.Denominator - rhs.Numerator * lhs.Denominator,
                                lhs.Denominator * rhs.Denominator);
        }

        public static Rational operator *(Rational lhs, Rational rhs)
        {
            return new Rational(lhs.Numerator * rhs.Numerator,
                                lhs.Denominator * rhs.Denominator);
        }

        public static Rational operator /(Rational lhs, Rational rhs)
        {
            return new Rational(lhs.Numerator * rhs.Denominator,
                                lhs.Denominator * rhs.Numerator);
        }

        public static Rational operator -(Rational rhs)
        {
            return new Rational(-rhs.Numerator, rhs.Denominator);
        }

        public static bool operator ==(Rational lhs, Rational rhs)
        {
            return lhs.Numerator == rhs.Numerator && lhs.Denominator == rhs.Denominator;
        }

        public static bool operator !=(Rational lhs, Rational rhs)
        {
            return lhs.Numerator != rhs.Numerator || lhs.Denominator != rhs.Denominator;
        }

        public static bool operator <(Rational lhs, Rational rhs)
        {
            return (double)lhs.Numerator / lhs.Denominator < (double)rhs.Numerator / rhs.Denominator;
        }

        public static bool operator <=(Rational lhs, Rational rhs)
        {
            return (double)lhs.Numerator / lhs.Denominator <= (double)rhs.Numerator / rhs.Denominator;
        }

        public static bool operator >(Rational lhs, Rational rhs)
        {
            return (double)lhs.Numerator / lhs.Denominator > (double)rhs.Numerator / rhs.Denominator;
        }

        public static bool operator >=(Rational lhs, Rational rhs)
        {
            return (double)lhs.Numerator / lhs.Denominator >= (double)rhs.Numerator / rhs.Denominator;
        }

        private static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }

            return GCD(b, a % b);
        }
    }
}