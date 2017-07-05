namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
            where T : BaseClass;
    }
}
