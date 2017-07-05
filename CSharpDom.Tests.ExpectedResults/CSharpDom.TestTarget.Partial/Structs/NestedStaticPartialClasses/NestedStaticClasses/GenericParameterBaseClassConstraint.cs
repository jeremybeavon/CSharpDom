namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
