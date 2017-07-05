namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
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
