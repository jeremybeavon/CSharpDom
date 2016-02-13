namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        T Method<T>()
            where T : new();
    }
}
