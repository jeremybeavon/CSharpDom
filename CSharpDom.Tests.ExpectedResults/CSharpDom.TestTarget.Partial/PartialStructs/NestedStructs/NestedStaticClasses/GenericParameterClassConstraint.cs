namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
