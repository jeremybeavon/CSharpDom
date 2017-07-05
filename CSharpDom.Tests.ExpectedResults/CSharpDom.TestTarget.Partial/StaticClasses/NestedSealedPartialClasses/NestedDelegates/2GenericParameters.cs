namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedDelegateWith2GenericParameters
    {
        public sealed partial class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
