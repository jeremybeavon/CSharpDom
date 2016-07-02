namespace CSharpDom.TestTarget.Structs.NestedDelegates
{
    public struct StructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
            where T : class, IInterface, new();
    }
}
