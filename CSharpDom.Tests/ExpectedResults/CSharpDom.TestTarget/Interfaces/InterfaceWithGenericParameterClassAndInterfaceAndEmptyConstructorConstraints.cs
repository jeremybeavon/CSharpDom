namespace CSharpDom.TestTarget.Interfaces
{
    public interface InterfaceWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
