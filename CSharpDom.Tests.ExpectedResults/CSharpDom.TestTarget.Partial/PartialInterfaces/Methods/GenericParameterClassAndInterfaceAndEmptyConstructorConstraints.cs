namespace CSharpDom.TestTarget.Partial.PartialInterfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        T Method<T>()
            where T : class, IInterface, new();
    }
}
