namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
            where T : new();
    }
}
