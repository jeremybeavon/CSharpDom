namespace CSharpDom.TestTarget.AbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
            where TKey : TValue;
    }
}
