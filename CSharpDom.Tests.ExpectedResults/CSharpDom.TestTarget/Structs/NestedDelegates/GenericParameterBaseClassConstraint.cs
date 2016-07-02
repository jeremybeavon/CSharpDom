namespace CSharpDom.TestTarget.Structs.NestedDelegates
{
    public struct StructWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
            where T : BaseClass;
    }
}
