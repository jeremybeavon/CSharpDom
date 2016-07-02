namespace CSharpDom.TestTarget.Interfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterBaseClassConstraint
    {
        T Method<T>()
            where T : BaseClass;
    }
}
