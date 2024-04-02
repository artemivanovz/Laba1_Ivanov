using Laba1_Ivanov;

namespace UniTest_Laba1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(-1, 0)]
        [TestCase(0, 0)]
        public void TestException(int a, int b)
        {
            Assert.Throws<ArgumentException>(() => new Rational(a, b));
        }

        [Test]
        [TestCase(1, 2, "1/2")]
        [TestCase(2, 4, "1/2")]
        [TestCase(4, 2, "2")]
        [TestCase(4, -2, "-2")]
        public void TestToString(int a1, int a2, string result)
        {
            var a = new Rational(a1, a2);
            Assert.That(a.ToString() == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, 5, 4)]
        [TestCase(1, 2, 1, 2, 1, 1)]
        [TestCase(-4, 5, 4, 10, -2, 5)]
        [TestCase(0, 1, 0, 1, 0, 1)]
        public void TestOperatorPlus(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);

            var result = a + b;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, -1, 4)]
        [TestCase(2, 4, -1, 4, 3, 4)]
        [TestCase(1, 1, 1, 5, 4, 5)]
        [TestCase(0, 1, 0, 1, 0, 1)]
        public void TestOperatorMinus(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);

            var result = a - b;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, 3, 8)]
        [TestCase(2, 4, -1, 4, -1, 8)]
        [TestCase(-1, -1, -1, -2, 1, 2)]
        [TestCase(0, 1, 0, 1, 0, 1)]
        public void TestOperatorMultip(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);

            var result = a * b;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 3, 4, 2, 3)]
        [TestCase(-1,2, 1, 5, -5, 2)]
        [TestCase(-1, -1, -1, -2, 2, 1)]
        [TestCase(0, 1, 1, 1, 0, 1)]
        public void TestOperatorDiv(int a1, int a2, int b1, int b2, int r1, int r2)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);

            var result = a / b;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, -1, 2)]
        [TestCase(-2, 4, 1, 2)]
        [TestCase(-2, -4, -1, 2)]
        public void TestOperatorUnarMinus(int a1, int a2, int r1, int r2)
        {
            var a = new Rational(a1, a2);

            var result = -a;

            Assert.That(result.Numerator == r1, Is.True);
            Assert.That(result.Denominator == r2, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, true)]
        [TestCase(0, 1, 0, 1, true)]
        [TestCase(-4, -2, -16, -8, true)]
        [TestCase(1, 2, 2, 2, false)]
        public void TestOperatorEqual(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);
            Assert.That((a == b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(0, 1, 0, 1, false)]
        [TestCase(-4, -2, -16, -8, false)]
        [TestCase(1, 2, 2, 2, true)]
        public void TestOperatorNotEqual(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);
            Assert.That((a != b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(0, 1, 0, 1, false)]
        [TestCase(-4, -2, -16, -8, false)]
        [TestCase(1, 2, 2, 2, true)]
        public void TestOperatorLess(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);
            Assert.That((a < b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, true)]
        [TestCase(0, 1, 0, 1, true)]
        [TestCase(-4, -2, -16, -8, true)]
        [TestCase(2, 2, 1, 2, false)]
        public void TestOperatorLessEqual(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);
            Assert.That((a <= b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, false)]
        [TestCase(0, 1, 0, 1, false)]
        [TestCase(-4, -2, -16, -8, false)]
        [TestCase(2, 2, 1, 2, true)]
        public void TestOperatorMore(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);
            Assert.That((a > b) == result, Is.True);
        }
        [Test]
        [TestCase(1, 2, 2, 4, true)]
        [TestCase(0, 1, 0, 1, true)]
        [TestCase(-4, -2, -16, -8, true)]
        [TestCase(1, 2, 2, 2, false)]
        public void TestOperatorMoreEqual(int a1, int a2, int b1, int b2, bool result)
        {
            var a = new Rational(a1, a2);
            var b = new Rational(b1, b2);
            Assert.That((a >= b) == result, Is.True);
        }
    }
}