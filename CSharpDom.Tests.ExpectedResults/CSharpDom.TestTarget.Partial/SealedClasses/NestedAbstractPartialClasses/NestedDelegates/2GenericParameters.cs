namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedDelegateWith2GenericParameters
    {
        public abstract partial class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
