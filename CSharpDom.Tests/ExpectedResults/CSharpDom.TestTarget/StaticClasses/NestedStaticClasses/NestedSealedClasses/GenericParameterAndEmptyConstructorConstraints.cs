namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
