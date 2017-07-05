namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedDelegates
{
    public class ClassWithNestedStaticPartialClassWithNestedDelegateWith2GenericParameters
    {
        public static partial class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
