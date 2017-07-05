namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
            where T : IInterface;
    }
}
