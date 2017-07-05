namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStaticClasses
{
    public struct StructWithNestedStructWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
