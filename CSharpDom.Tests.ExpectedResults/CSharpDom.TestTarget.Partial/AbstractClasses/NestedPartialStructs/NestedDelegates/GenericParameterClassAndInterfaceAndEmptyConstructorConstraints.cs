namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedDelegates
{
    public abstract class AbstractClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
