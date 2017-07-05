namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
