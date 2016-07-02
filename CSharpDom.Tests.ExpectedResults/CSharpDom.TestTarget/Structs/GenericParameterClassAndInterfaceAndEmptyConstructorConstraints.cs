namespace CSharpDom.TestTarget.Structs
{
    public struct StructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
