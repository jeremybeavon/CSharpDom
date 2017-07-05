namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads
    {
        public struct Struct
        {
            public static bool operator <(Struct parameter1, Struct parameter2)
            {
                return default(bool);
            }

            public static bool operator >(Struct parameter1, Struct parameter2)
            {
                return default(bool);
            }
        }
    }
}
