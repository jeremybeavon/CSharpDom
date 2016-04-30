namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedClassWithNestedDelegateWith2GenericParameters
    {
        public sealed class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
