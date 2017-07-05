namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
            where T : new();
    }
}
