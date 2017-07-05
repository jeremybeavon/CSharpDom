namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStructs
{
    public struct StructWithNestedStructWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
