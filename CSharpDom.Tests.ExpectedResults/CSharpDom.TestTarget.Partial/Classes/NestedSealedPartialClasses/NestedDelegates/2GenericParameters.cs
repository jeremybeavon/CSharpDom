namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedDelegates
{
    public class ClassWithNestedSealedPartialClassWithNestedDelegateWith2GenericParameters
    {
        public sealed partial class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
