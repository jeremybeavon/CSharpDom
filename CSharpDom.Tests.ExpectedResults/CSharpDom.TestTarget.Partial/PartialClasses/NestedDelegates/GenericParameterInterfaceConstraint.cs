namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedDelegates
{
    public partial class PartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
            where T : IInterface;
    }
}
