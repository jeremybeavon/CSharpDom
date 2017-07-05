namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
            where T : IInterface;
    }
}
