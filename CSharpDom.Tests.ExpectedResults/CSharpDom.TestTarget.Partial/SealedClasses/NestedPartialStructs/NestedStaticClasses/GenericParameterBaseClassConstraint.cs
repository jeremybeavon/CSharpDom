namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterBaseClassConstraint
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
