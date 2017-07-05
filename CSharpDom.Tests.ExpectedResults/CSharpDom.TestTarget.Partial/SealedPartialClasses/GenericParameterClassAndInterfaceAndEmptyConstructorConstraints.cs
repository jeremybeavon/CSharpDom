namespace CSharpDom.TestTarget.Partial.SealedPartialClasses
{
    public sealed partial class SealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>
        where T : class, IInterface, new()
    {
    }
}
