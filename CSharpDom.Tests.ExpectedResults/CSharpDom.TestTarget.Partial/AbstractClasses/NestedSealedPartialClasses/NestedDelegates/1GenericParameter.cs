namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedDelegateWith1GenericParameter
    {
        public sealed partial class Class
        {
            public delegate void DelegateWith1GenericParameter<T>();
        }
    }
}
