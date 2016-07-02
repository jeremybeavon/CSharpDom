namespace CSharpDom.TestTarget.AbstractClasses
{
    public abstract class AbstractClassWithGenericParameterClassAndEmptyConstructorConstraints<T>
        where T : class, new()
    {
    }
}
