namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct<T>
            where T : new()
        {
        }
    }
}
