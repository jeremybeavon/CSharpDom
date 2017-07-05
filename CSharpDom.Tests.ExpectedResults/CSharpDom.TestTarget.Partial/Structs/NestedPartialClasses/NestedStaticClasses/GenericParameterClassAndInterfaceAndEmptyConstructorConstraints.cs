namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
