namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
