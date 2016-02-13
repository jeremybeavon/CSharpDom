namespace CSharpDom.TestTarget.Delegates
{
    public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
        where T : class, IInterface, new();
}
