namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
