namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
