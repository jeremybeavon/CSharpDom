namespace CSharpDom.TestTarget.Classes.AbstractClasses
{
    public abstract class AbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
