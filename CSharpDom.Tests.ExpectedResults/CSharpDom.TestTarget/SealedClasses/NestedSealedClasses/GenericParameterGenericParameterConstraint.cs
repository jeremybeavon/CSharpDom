namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
