namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses
{
    public partial struct PartialStructWithWithNestedSealedClassWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
