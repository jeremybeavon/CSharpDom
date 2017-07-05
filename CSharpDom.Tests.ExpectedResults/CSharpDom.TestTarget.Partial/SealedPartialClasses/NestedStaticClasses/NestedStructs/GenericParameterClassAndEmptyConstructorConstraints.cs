namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
