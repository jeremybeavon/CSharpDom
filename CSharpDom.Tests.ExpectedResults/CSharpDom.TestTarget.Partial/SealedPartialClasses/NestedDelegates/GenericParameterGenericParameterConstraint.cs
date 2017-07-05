namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
            where TKey : TValue;
    }
}
