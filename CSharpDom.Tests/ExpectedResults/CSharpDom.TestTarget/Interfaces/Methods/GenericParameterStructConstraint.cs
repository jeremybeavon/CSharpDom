namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterStructConstraint
    {
        T Method<T>()
            where T : struct;
    }
}
