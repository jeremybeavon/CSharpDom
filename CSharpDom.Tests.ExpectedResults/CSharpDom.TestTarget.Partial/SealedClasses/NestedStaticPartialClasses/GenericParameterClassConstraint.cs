namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public static class Class<T>
            where T : class
        {
        }
    }
}
