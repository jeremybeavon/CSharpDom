namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint
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
