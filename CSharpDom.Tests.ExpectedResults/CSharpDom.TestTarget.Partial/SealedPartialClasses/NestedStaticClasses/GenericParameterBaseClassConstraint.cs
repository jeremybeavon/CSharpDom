namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
