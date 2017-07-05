namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedDelegateWith2GenericParameters
    {
        public sealed partial class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
