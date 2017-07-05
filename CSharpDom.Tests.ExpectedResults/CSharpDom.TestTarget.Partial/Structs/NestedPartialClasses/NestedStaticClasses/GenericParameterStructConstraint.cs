namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
