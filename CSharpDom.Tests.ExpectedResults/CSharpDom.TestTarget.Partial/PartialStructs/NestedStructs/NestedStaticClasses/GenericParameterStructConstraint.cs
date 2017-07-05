namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedStaticClassWithGenericParameterStructConstraint
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
