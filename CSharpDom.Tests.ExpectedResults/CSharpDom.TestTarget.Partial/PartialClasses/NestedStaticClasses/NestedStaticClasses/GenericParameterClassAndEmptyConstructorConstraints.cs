namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
