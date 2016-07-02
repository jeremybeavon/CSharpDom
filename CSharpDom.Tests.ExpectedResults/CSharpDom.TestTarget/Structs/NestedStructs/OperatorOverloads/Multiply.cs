namespace CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithMultiplyOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator *(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
