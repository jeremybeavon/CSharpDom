namespace CSharpDom.TestTarget.Classes.NestedDelegates
{
    public class ClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
            where T : class, IInterface, new();
    }
}
