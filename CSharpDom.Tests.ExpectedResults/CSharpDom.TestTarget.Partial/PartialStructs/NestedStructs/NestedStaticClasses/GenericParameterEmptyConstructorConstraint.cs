namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
