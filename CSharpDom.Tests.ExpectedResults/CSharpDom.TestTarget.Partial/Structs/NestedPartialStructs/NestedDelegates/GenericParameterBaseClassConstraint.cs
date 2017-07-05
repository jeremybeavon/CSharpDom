namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedDelegates
{
    public struct StructWithNestedStructWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
