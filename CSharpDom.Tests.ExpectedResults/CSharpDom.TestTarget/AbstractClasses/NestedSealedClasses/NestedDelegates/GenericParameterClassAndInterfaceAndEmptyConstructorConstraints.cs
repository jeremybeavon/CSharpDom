namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
