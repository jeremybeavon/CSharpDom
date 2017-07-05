namespace CSharpDom.TestTarget.Partial.PartialStructs
{
    public partial struct PartialStructWithWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
