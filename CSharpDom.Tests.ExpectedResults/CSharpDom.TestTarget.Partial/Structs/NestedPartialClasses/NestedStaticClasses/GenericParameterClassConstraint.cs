namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
