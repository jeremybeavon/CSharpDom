namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
