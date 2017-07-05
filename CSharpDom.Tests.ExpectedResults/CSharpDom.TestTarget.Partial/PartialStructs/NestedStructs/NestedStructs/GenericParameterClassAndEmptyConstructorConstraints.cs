namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedStructs
{
    public partial struct PartialStructWithWithNestedStructWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public struct Struct
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
