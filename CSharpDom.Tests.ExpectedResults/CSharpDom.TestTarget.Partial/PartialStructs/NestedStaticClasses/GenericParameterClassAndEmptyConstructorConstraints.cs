namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
