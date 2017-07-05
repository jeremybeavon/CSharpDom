namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterStructConstraint
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
