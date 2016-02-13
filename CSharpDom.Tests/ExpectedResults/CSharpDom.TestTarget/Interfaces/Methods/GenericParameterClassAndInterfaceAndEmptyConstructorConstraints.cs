namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        T Method<T>()
            where T : class, IInterface, new();
    }
}
