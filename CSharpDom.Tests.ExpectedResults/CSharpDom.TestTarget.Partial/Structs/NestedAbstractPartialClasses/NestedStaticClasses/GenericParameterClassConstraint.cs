namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
