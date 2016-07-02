namespace CSharpDom.TestTarget.Delegates
{
    public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
        where TKey : TValue;
}
