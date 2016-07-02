namespace CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithAndOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator &(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
