namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
