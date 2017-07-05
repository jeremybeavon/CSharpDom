namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithMinusOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator -(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
