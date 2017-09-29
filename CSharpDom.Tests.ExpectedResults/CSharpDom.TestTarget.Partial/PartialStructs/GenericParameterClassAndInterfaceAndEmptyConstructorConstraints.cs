namespace CSharpDom.TestTarget.Partial.PartialStructs
{
    public partial struct PartialStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
