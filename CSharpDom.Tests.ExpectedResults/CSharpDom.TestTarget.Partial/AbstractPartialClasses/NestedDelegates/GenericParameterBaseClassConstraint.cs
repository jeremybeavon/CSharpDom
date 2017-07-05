namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
            where T : BaseClass;
    }
}
