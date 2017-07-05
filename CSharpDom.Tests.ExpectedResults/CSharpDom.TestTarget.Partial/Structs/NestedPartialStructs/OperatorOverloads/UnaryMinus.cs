namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithUnaryMinusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator -(Struct parameter1)
            {
                return default(Struct);
            }
        }
    }
}
