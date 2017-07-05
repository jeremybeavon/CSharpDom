namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
