namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
            where T : IInterface;
    }
}
