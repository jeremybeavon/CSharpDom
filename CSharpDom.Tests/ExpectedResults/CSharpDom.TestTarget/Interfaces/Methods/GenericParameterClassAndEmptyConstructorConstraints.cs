namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        T Method<T>()
            where T : class, new();
    }
}
