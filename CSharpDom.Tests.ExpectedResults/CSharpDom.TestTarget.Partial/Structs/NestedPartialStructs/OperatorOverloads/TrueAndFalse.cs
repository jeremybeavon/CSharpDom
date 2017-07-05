namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithTrueAndFalseOperatorOverloads
    {
        public struct Struct
        {
            public static bool operator true(Struct parameter1)
            {
                return default(bool);
            }

            public static bool operator false(Struct parameter1)
            {
                return default(bool);
            }
        }
    }
}
