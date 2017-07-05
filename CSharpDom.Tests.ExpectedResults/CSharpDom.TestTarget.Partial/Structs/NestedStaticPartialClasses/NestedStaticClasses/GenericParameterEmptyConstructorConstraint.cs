namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
