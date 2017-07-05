namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStaticClasses
{
    public struct StructWithNestedStructWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
