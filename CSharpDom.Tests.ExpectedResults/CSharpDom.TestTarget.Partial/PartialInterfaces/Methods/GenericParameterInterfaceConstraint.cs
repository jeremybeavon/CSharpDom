namespace CSharpDom.TestTarget.Partial.PartialInterfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterInterfaceConstraint
    {
        T Method<T>()
            where T : IInterface;
    }
}
