namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedDelegates
{
    public struct StructWithNestedStructWithNestedClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
