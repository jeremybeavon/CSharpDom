namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
