namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedDelegates
{
    public struct StructWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
