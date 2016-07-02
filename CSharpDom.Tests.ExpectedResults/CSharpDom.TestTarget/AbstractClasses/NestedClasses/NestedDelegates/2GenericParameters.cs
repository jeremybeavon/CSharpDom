namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedClassWithNestedDelegateWith2GenericParameters
    {
        public class Class
        {
            public delegate void DelegateWith2GenericParameters<TKey, TValue>();
        }
    }
}
