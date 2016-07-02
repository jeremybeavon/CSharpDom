namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedClassWithNestedDelegateWith2GenericParameters
    {
        public sealed class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
