namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
