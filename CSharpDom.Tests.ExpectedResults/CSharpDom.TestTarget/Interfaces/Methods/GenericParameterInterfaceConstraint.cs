namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterInterfaceConstraint
    {
        T Method<T>()
            where T : IInterface;
    }
}
