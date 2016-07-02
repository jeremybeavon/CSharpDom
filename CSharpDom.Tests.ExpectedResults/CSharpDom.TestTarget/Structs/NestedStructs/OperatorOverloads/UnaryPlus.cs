namespace CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithUnaryPlusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator +(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
