namespace CSharpDom.TestTarget.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
