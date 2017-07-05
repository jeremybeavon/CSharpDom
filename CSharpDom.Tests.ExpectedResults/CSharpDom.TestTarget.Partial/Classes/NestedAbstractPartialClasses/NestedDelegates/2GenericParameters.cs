namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedDelegates
{
    public class ClassWithNestedAbstractPartialClassWithNestedDelegateWith2GenericParameters
    {
        public abstract partial class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
