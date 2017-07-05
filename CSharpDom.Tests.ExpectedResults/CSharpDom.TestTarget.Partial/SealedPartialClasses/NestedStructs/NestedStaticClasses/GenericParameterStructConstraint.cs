namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStaticClassWithGenericParameterStructConstraint
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
