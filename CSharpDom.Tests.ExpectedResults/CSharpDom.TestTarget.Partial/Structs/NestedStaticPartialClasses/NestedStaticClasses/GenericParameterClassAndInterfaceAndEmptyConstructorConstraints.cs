namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
