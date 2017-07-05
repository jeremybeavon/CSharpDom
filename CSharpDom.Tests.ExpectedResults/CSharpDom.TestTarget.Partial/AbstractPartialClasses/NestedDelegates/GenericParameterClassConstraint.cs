namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public delegate void DelegateWithGenericParameterClassConstraint<T>()
            where T : class;
    }
}
