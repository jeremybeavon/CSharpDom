namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStaticClasses
{
    public struct StructWithNestedStructWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
