namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
