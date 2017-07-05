namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class<T>
            where T : new()
        {
        }
    }
}
