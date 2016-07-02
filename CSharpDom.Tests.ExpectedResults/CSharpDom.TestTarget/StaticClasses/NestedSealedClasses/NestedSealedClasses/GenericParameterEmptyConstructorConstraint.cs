namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public sealed class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
