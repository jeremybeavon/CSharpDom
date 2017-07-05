namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
