namespace CSharpDom.TestTarget.Partial.PartialInterfaces.Methods
{
    public interface IInterfaceWithMethodWithGenericParameterStructConstraint
    {
        T Method<T>()
            where T : struct;
    }
}
