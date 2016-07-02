namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
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
