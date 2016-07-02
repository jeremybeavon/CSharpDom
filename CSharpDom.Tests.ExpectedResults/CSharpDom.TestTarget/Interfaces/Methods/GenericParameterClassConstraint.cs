namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterClassConstraint
    {
        T Method<T>()
            where T : class;
    }
}
