namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
