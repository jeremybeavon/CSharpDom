namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStructWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
