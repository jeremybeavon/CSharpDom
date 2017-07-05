namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, new()
        {
        }
    }
}
