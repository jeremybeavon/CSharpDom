namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.OperatorOverloads
{
    public struct StructWithNestedStructWithModuloOperatorOverload
    {
        public struct Struct
        {
            public static Struct operator %(Struct parameter1, Struct parameter2)
            {
                return default(Struct);
            }
        }
    }
}
