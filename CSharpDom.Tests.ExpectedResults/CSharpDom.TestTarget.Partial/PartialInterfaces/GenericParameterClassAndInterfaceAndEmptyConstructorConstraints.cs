namespace CSharpDom.TestTarget.Partial.PartialInterfaces
{
    public partial interface InterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
