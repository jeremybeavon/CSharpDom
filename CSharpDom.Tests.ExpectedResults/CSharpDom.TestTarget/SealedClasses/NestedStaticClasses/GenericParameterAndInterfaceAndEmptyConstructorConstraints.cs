namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
