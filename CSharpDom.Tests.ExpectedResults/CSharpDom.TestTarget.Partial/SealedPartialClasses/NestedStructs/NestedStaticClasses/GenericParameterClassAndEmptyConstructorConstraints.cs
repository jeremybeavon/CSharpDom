namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
