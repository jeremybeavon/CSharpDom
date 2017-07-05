namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
