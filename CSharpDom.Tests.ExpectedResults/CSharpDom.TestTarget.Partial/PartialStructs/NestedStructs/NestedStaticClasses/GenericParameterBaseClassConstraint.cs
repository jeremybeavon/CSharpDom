namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStructWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
