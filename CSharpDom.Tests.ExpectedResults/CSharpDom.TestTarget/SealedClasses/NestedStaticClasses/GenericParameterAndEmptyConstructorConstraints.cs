namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
