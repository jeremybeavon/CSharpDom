namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
