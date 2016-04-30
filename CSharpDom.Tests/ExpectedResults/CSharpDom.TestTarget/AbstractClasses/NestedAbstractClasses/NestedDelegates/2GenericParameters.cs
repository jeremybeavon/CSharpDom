namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedDelegateWith2GenericParameters
    {
        public abstract class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
