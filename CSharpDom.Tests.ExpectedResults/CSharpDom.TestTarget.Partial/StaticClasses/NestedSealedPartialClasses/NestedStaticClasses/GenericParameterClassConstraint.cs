namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
