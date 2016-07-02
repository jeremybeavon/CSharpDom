namespace CSharpDom.TestTarget.AbstractClasses
{
    public abstract class AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
