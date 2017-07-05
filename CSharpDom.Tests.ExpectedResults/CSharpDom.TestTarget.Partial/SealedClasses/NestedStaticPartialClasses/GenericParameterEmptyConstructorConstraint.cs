namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
