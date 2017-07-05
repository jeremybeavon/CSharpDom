namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
