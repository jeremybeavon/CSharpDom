namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
            where TKey : TValue;
    }
}
