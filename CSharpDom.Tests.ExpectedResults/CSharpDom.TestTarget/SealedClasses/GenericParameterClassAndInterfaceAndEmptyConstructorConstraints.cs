namespace CSharpDom.TestTarget.SealedClasses
{
    public sealed class SealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
