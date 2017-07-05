namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
