namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedSealedPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
