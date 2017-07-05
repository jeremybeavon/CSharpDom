namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class<T>
            where T : class
        {
        }
    }
}
