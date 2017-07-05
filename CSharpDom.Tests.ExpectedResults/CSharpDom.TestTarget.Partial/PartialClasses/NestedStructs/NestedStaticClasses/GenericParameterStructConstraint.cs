namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedStaticClasses
{
    public partial class PartialClassWithNestedStructWithNestedStaticClassWithGenericParameterStructConstraint
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
