namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
            where TKey : TValue;
    }
}
