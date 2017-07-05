namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
