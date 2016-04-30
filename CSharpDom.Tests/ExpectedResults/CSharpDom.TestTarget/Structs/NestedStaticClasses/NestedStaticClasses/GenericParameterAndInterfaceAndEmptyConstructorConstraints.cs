namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
