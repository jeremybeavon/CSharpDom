namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
            where T : class, IInterface, new();
    }
}
