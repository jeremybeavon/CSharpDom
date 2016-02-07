namespace CSharpDom.TestTarget.Classes
{
    public class ClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
