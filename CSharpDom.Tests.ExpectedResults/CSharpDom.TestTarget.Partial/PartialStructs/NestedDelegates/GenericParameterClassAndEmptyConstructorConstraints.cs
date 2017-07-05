namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
            where T : class, new();
    }
}
