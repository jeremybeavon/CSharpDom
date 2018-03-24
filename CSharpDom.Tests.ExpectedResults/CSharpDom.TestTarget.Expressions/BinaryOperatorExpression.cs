namespace CSharpDom.TestTarget.Expressions
{
    public sealed class BinaryOperatorExpression
    {
        public int TestAdd(int x, int y)
        {
            return x + y;
        }

        public void TestAddAssign(ref int x, int y)
        {
            x += y;
        }

        public void TestAssign(ref int x, int y)
        {
            x = y;
        }

        public int TestBitwiseAnd(int x, int y)
        {
            return x & y;
        }

        public void TestBitwiseAndAssign(ref int x, int y)
        {
            x &= y;
        }

        public int TestBitwiseExclusiveOr(int x, int y)
        {
            return x ^ y;
        }

        public void TestBitwiseExclusiveOrAssign(ref int x, int y)
        {
            x ^= y;
        }

        public int TestBitwiseOr(int x, int y)
        {
            return x | y;
        }

        public void TestBitwiseOrAssign(ref int x, int y)
        {
            x |= y;
        }

        public object TestCoalesce(object x, object y)
        {
            return x ?? y;
        }

        public int TestDivide(int x, int y)
        {
            return x / y;
        }

        public void TestDivideAssign(ref int x, int y)
        {
            x /= y;
        }

        public bool TestEqual(int x, int y)
        {
            return x == y;
        }

        public bool TestGreaterThan(int x, int y)
        {
            return x > y;
        }

        public bool TestGreaterThanOrEqual(int x, int y)
        {
            return x >= y;
        }

        public int TestLeftShift(int x, int y)
        {
            return x << y;
        }

        public void TestLeftShiftAssign(ref int x, int y)
        {
            x <<= y;
        }

        public bool TestLessThan(int x, int y)
        {
            return x < y;
        }

        public bool TestLessThanOrEqual(int x, int y)
        {
            return x <= y;
        }

        public bool TestLogicalAnd(bool x, bool y)
        {
            return x && y;
        }

        public bool TestLogicalOr(bool x, bool y)
        {
            return x || y;
        }

        public int TestModulo(int x, int y)
        {
            return x % y;
        }

        public void TestModuloAssign(ref int x, int y)
        {
            x %= y;
        }

        public int TestMultiply(int x, int y)
        {
            return x * y;
        }

        public void TestMultiplyAssign(ref int x, int y)
        {
            x *= y;
        }

        public bool NotEqual(int x, int y)
        {
            return x != y;
        }

        public int TestRightShift(int x, int y)
        {
            return x >> y;
        }

        public void TestRightShiftAssign(ref int x, int y)
        {
            x >>= y;
        }

        public int TestSubtract(int x, int y)
        {
            return x - y;
        }

        public void TestSubtractAssign(ref int x, int y)
        {
            x -= y;
        }

        public string TestTypeAs(object obj)
        {
            return obj as string;
        }
    }
}
