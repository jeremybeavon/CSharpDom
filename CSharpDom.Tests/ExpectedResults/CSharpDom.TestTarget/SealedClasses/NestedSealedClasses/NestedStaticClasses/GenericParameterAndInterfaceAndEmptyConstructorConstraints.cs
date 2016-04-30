namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
