namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedDelegateWithGenericParameterStructConstraint
    {
        public delegate void DelegateWithGenericParameterStructConstraint<T>()
            where T : struct;
    }
}
