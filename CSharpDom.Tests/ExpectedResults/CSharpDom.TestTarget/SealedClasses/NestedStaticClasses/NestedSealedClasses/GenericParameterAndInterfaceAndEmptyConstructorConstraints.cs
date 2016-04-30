namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
