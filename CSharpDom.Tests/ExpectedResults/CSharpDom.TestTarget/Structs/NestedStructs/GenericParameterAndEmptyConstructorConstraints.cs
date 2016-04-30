namespace CSharpDom.TestTarget.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct<T>
            where T : class, new()
        {
        }
    }
}
