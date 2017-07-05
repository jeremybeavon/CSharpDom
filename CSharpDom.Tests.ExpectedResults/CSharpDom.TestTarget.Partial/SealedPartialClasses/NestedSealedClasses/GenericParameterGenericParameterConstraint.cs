namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
