namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
