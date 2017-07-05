namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedDelegates
{
    public partial class PartialClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
            where T : class, IInterface, new();
    }
}
