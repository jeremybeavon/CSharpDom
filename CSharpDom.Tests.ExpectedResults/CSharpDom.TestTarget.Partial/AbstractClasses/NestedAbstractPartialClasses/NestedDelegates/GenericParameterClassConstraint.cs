namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
