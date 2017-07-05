namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
