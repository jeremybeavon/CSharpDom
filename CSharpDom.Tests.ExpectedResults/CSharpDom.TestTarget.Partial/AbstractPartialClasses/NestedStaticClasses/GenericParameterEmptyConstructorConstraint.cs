namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
