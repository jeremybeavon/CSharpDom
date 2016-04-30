namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedDelegateWith2GenericParameters
    {
        public abstract class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
