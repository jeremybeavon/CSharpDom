namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
