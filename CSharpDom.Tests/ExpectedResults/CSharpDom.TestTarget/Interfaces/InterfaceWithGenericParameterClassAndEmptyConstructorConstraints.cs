namespace CSharpDom.TestTarget.Interfaces
{
    public interface InterfaceWithGenericParameterClassAndEmptyConstructorConstraints<T>
        where T : class, new()
    {
    }
}
