namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedDelegates
{
    public partial class PartialClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
            where TKey : TValue;
    }
}
