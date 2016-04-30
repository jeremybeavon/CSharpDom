namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
