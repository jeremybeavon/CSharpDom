namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedDelegates
{
    public struct StructWithNestedStructWithNestedDelegateWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
