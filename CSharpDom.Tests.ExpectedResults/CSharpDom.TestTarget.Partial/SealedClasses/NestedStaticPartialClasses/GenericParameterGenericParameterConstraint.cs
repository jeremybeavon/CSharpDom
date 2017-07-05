namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
