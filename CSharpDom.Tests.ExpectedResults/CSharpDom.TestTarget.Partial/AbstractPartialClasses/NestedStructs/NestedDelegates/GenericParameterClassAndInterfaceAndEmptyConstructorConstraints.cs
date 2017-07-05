namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
