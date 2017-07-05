namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class<T>
            where T : class
        {
        }
    }
}
