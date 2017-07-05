namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
