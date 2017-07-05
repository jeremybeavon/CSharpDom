namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
