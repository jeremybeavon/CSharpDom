namespace CSharpDom.TestTarget.Structs.OperatorOverloads
{
    public struct StructWithLessThanAndGreaterThanOperatorOverloads
    {
        public static bool operator <(StructWithLessThanAndGreaterThanOperatorOverloads parameter1, StructWithLessThanAndGreaterThanOperatorOverloads parameter2)
        {
            return default(bool);
        }

        public static bool operator >(StructWithLessThanAndGreaterThanOperatorOverloads parameter1, StructWithLessThanAndGreaterThanOperatorOverloads parameter2)
        {
            return default(bool);
        }
    }
}
