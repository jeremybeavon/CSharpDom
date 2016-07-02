namespace CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithLogicalNotOperatorOverload
    {
        public struct Struct
        {
            public static bool operator !(Struct parameter1)
            {
                return default(bool);
            }
        }
    }
}
