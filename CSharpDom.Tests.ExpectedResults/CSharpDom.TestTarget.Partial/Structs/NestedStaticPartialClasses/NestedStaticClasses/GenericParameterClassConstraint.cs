namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
