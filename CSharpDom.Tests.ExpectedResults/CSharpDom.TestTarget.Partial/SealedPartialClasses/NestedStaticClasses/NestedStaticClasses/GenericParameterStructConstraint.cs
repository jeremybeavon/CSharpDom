namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
