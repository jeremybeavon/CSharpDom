namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStaticClasses
{
    public struct StructWithNestedStructWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
