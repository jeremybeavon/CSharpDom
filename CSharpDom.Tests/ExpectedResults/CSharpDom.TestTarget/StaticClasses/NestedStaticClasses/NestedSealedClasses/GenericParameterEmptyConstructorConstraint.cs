namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
