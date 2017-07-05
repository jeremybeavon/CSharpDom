namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public static class Class<T>
            where T : class
        {
        }
    }
}
