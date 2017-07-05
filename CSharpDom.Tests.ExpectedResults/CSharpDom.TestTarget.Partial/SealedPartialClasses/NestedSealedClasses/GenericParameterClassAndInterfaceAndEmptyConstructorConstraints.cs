namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
