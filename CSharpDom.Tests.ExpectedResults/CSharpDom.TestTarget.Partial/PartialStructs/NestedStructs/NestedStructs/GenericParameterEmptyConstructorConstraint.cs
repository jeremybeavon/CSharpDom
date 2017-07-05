namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
