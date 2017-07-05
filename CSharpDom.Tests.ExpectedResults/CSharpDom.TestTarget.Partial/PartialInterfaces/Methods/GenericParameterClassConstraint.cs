namespace CSharpDom.TestTarget.Partial.PartialInterfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterClassConstraint
    {
        T Method<T>()
            where T : class;
    }
}
