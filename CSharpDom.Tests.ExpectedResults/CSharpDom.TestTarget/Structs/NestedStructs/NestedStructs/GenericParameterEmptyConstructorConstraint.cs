namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedStructs
{
    public struct StructWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
