namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct<T>
            where T : class
        {
        }
    }
}
