namespace CSharpDom.TestTarget.Partial.PartialInterfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        T Method<T>()
            where T : new();
    }
}
