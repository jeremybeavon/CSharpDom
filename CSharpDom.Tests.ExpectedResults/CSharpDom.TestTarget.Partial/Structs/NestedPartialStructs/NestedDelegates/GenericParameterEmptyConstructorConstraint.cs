namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedDelegates
{
    public struct StructWithNestedStructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
