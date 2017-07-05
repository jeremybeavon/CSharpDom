namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
