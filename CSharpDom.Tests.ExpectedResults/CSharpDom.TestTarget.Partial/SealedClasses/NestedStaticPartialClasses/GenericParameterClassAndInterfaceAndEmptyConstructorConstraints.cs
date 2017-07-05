namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
