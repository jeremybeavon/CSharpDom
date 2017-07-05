namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
