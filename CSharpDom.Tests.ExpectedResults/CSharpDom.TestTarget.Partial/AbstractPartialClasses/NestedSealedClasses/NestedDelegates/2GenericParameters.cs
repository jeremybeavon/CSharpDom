namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedDelegateWith2GenericParameters
    {
        public sealed class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
