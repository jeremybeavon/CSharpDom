namespace CSharpDom.TestTarget.Structs.NestedStructs
{
    public struct StructWithNestedStructWithGenericParameterClassConstraint
    {
        public struct Struct<T>
            where T : class
        {
        }
    }
}
