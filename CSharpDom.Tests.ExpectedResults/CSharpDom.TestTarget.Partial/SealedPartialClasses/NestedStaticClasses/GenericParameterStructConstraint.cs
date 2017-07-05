namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
