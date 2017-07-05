namespace CSharpDom.TestTarget.Partial.PartialInterfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        T Method<T>()
            where T : class, new();
    }
}
