namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
