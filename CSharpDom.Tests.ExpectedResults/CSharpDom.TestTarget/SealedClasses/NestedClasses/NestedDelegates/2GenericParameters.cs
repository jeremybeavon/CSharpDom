namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedClassWithNestedDelegateWith2GenericParameters
    {
        public class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
