namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
