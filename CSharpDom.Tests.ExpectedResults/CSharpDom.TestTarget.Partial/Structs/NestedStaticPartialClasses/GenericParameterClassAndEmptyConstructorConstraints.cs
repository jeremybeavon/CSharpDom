namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
