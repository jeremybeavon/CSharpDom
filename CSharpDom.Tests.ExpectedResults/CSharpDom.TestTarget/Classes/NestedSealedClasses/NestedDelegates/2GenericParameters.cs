namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedDelegates
{
    public class ClassWithNestedSealedClassWithNestedDelegateWith2GenericParameters
    {
        public sealed class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
