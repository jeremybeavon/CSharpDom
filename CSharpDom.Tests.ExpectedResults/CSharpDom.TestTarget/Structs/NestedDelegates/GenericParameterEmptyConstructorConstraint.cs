namespace CSharpDom.TestTarget.Structs.NestedDelegates
{
    public struct StructWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
            where T : new();
    }
}
