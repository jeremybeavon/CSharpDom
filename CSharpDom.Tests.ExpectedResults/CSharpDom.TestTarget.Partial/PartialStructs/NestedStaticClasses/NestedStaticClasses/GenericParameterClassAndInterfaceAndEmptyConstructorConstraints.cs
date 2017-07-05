namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
