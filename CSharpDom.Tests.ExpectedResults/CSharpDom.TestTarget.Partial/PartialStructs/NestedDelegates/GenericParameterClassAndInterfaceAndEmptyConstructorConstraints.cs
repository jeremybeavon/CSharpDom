namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
            where T : class, IInterface, new();
    }
}
