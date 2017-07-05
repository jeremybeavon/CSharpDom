namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithGenericParameterClassConstraint
    {
        public delegate void DelegateWithGenericParameterClassConstraint<T>()
            where T : class;
    }
}
