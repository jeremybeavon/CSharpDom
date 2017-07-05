namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
