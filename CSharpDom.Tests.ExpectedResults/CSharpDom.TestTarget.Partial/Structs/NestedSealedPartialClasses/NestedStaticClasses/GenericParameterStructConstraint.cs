namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
