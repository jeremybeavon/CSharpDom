namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
