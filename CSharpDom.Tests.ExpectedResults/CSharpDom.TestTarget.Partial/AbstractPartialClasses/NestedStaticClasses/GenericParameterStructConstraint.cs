namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
