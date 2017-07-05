namespace CSharpDom.TestTarget.Partial.PartialInterfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterBaseClassConstraint
    {
        T Method<T>()
            where T : BaseClass;
    }
}
