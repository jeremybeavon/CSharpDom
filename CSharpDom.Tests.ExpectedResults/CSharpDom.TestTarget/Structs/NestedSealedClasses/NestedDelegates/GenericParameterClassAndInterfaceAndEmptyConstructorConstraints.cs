namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedDelegates
{
    public struct StructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
