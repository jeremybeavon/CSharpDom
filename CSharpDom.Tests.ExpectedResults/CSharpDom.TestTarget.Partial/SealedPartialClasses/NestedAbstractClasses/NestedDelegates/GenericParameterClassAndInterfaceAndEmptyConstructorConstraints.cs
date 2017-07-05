namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
