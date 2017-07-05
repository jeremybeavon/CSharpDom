namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
