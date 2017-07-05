namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.OperatorOverloads
{
    public partial struct PartialStructWithWithNestedStructWithLessThanAndGreaterThanOperatorOverloads
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
