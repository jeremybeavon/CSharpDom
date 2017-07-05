namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
