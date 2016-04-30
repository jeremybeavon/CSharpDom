namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
