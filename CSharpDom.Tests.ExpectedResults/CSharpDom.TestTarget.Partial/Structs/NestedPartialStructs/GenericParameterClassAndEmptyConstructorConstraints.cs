namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, new()
        {
        }
    }
}
