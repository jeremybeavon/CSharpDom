namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
