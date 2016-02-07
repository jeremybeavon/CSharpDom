namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithLessThanAndGreaterThanOperators
    {
        public static bool operator <(StructWithLessThanAndGreaterThanOperators parameter1, StructWithLessThanAndGreaterThanOperators parameter2)
        {
            return default(bool);
        }

        public static bool operator >(StructWithLessThanAndGreaterThanOperators parameter1, StructWithLessThanAndGreaterThanOperators parameter2)
        {
            return default(bool);
        }
    }
}
