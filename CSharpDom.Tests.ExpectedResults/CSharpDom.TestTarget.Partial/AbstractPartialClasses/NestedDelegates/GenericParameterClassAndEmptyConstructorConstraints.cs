namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
            where T : class, new();
    }
}
