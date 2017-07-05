namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
