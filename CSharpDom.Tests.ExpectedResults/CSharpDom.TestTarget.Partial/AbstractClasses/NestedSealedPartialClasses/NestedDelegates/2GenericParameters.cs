namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedDelegateWith2GenericParameters
    {
        public sealed partial class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
