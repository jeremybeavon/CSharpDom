namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedDelegateWith1GenericParameter
    {
        public sealed class Class
        {
            public delegate void DelegateWith1GenericParameter<T>();
        }
    }
}
