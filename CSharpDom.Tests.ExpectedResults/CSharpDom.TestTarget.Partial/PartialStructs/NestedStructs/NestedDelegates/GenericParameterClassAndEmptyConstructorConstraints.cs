namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedDelegates
{
    public partial struct PartialStructWithWithNestedStructWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
