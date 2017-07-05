namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
