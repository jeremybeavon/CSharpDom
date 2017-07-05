namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
