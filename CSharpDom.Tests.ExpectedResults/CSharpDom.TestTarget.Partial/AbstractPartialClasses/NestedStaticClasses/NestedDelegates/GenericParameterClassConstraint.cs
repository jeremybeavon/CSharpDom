namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
